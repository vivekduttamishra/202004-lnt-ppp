
//common to all person
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

//additional skills or behaviors
function teachDriving(person, veichle){

    //that can be added conditionally and dynamically
    if(person.age<18)
        return console.warn(`${person.name} you need to wait for ${18-person.age} years to drive`);

    if(person.licence)
        person.licence.push(veichle);
    else{
        person.licence=[veichle]; //dynamic property
        person.drive=function(v){ //dynmaic behavior
            for(var lv of person.licence){
                if(lv===v)
                    return console.log(`${this.name} is driving ${lv}`);
            }
            console.log(`${this.name} you are not allowed to drive ${v}`);
        }
    }  
}


var vivek=createPerson("Vivek",100);
var shivanshi=createPerson("Shivanshi",14);

console.log("beofre teachDriving()");
//console.dir(vivek);
//console.dir(shivanshi);

teachDriving(vivek,"Car");
teachDriving(vivek,"Bike");
teachDriving(shivanshi,"Car");

console.log("after teach driving");
//console.dir(vivek);
//console.dir(shivanshi);

vivek.drive('Car'); // can drive a car
vivek.drive('Bus'); // drive method exist. but no licence <--- method will still give output

shivanshi.drive('Car'); //<--- there is no drive method






