/**
 * @param {number[]} nums
 * @return {number[]}
 */
var getConcatenation = function(nums) {
    return [...nums, ...nums];
};

const arr = [1, 2, 3, 4];
const result = getConcatenation(arr);
