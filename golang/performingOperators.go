package main

import (
	"net/http"
	"strconv"

	"github.com/gin-gonic/gin"
)

func reinitializePermutationHandler(c *gin.Context) {
	// Parse 'n' parameter from the query string
	nParam := c.Query("n")
	n, err := strconv.Atoi(nParam)
	if err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid 'n' parameter"})
		return
	}

	// Call the reinitializePermutation function
	result := reinitializePermutation(n)

	// Return the result as a JSON response
	c.JSON(http.StatusOK, gin.H{"result": result})
}

func Print[T comparable](x T, s ...T) int {
	for i, v := range s {
		if v == x {
			return i

		}
	}
	return -1
}
func main() {
	// var router = gin.Default()
	// router.GET("/reinitializePermutationgo ", reinitializePermutationHandler)
	// router.Run(":8080")
	// fmt.Println(reinitializePermutation(6))
	http.HandleFunc("/reinitializePermutation", func(w http.ResponseWriter, r *http.Request) {
		pathNumber := r.URL.Query().Get("n")
		nums, err := strconv.Atoi(pathNumber)
		if err != nil {
			w.Write([]byte(err.Error()))
		}
		w.Write([]byte(strconv.Itoa(reinitializePermutation(nums))))
	})
	http.HandleFunc("/operations", func(w http.ResponseWriter, r *http.Request) {
		x, _ := strconv.Atoi(r.URL.Query().Get("x"))
		y, _ := strconv.Atoi(r.URL.Query().Get("y"))
		sum := x + y
		w.Write([]byte(strconv.Itoa(sum)))
	})
	http.HandleFunc("/findX", func(w http.ResponseWriter, r *http.Request) {
		x, _ := strconv.Atoi(r.URL.Query().Get("x"))
		arr := []int{1, 2, 3, 4, 5}
		w.Write([]byte(strconv.Itoa(Print(x, arr...))))

	})
	http.ListenAndServe(":8080", nil)
}
func finalValueAfterOperations(operations []string) int {
	var count int = 0
	for i := 0; i < len(operations); i++ {
		if operations[i] == "X++" || operations[i] == "++X" {
			count++
		}
		if operations[i] == "--X" || operations[i] == "X--" {
			count--
		}
	}
	return count
}

func reinitializePermutation(n int) int {
	if n <= 2 {
		return 1
	}
	var perm = make([]int, n)
	var arr = make([]int, n)
	var count = 0
	for i := 0; i < n; i++ {
		perm[i] = i
		if i%2 == 0 {
			arr[i] = perm[i/2]
		} else {
			arr[i] = perm[n/2+(i-1)/2]
		}
	}

	for i := 0; i < n; i++ {
		if arr[i] != perm[i] {
			count++
		}
	}
	return count
}
