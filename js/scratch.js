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

const k1 = {
    color1: "black",
    color2: "red"
};

const k2 = {
    color3: "green",
    color1: "blue",
    ...k1,

};
const k3 = undefined;

console.log(k3?.k);

function hi(message){
    console.log(message, ", Sup?");
}
function bye(message){
    console.log(message, ", Peace");
}

function whatToSay(func){
    func("Alex");
}

whatToSay(hi)
whatToSay(bye)

const arr = Array(100).fill(0).map((v,i) => i + 1);
const arr2 = Array(100).keys();
console.log(arr2);