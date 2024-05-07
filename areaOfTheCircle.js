

var value = process.argv.slice(2);


var circleCompute = (r) => {

    var result = Math.PI * Math.pow(r,2);

    console.log(`Daire Alanı:${result} --> Yarıçap ${r} `);
}


console.log(value[0])

circleCompute(value[0]*1);




