var results = [];
var sum = 0;
for (var i = 1; i < 1000; i++) {
    if ((i % 3 === 0) || (i % 5 === 0)){
        results.push(i);
        sum += i;
    }
}

console.log(results);
console.log(sum);

