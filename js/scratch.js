class animal{
    dna = "B";
}

class dog extends animal{
    run(){
        console.log("run");
    }
}

const p1 = new dog();

console.log(p1.dna);