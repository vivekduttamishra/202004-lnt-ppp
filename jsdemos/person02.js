
function createPerson(name, age){

    var person=new Object(); 
    person.name=name;
    person.age=age;
    
    person.eat= function(food){
        console.log(`${this.name} eats ${food}`);
    };

    person.move=function(to){
        console.log(`${this.name} goes to ${to}`);
    };

    person.sleep=function(sleepTime){
        setTimeout(()=>{
            console.log(`${person.name} wakes`);
        },sleepTime);
        console.log(`${person.name} going to sleep for ${sleepTime} ms`);
    }
    
    return person;
}

var vivek=createPerson("Vivek",100);

var shivanshi=createPerson("Shivanshi",14);

vivek.eat("Lunch");
shivanshi.eat("Maggi");

vivek.sleep(5000);


