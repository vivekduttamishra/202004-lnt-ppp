

var vivek=new Object(); 
//we have an object with no defined property or behavior

//we can add properties and behavior to an existing object
vivek.name="Vivek";
vivek.age=100;

console.log(vivek.name,vivek.age);
console.dir(vivek);

vivek.eat= function(food){
    console.log(`${this.name} eats ${food}`);
};

vivek.eat('Lunch');