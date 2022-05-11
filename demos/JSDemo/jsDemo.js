'use strict';
// let myform = document.getElementsByTagName('form');

// this is the whole kitten caboodle. The page. text, images... everything
window.addEventListener('load', (e) => {
  console.log("load happened");
  //console.log(e.target);
  for (let i = 0; i < 100; i++) { }
});

// DOMContentLoaded is fired when the DOM Content is Loaded. THis doesn't include images and other externally provided data.
document.addEventListener('DOMContentLoaded', () => {
  console.log('DOM fully loaded and parsed');
  for (let i = 0; i < 100; i++) { }
});

//the readystate property is updated every time the loading enters a new phase.
document.addEventListener('readystatechange', (e) => {
  console.log(`readystate is ${document.readyState}.`);
  for (let i = 0; i < 100; i++) { }
});

document.querySelector("#myformid").addEventListener("submit", (e) => {
  e.preventDefault();
  // e.stopPropagation();
  console.log('this is the message');
  var form = document.getElementsByName('myform1');
  console.log(form);
  console.log(form[0][0].value);//
  console.log(form[0][1].value);//
  console.log(form[0][2].value);//
  console.log(form[0][3].value);//
  console.log(form[0][4].value);//
  console.log(form[0][5].value);//the submit button
});

// alert("This is the alert");


// let label1 = document.querySelector('#labelName')
// label1.addEventListener('click', (e) => {
//   //e.preventDefault();//to prevent the page from reloading

//   if (e.target.innerText == "Check this for secrecy.") {
//     e.target.innerText = "I've been clicked."
//   }
//   else if (e.target.innerText == "I've been clicked.") {
//     e.target.innerText = "Check this for secrecy.";
//   }
// });
let one = true;
if (one) {
  var str1 = 'Mark';// var has 'hoisting'
}


console.log(`The string is ${str1}`);
//console.log(str1);
let str2 = 'dlkjhdfkjndflkbvj';
if (one) {
  str2 = 'Arely';// this str2 'shadows' str2 from above.
}
console.log(`The string is ${str2}`);
const str3 = 'Maya';
// str3 = 'mi bebe!';

// you can delare and instantiate different typed variables in a row like this.
let mark = 'Mark1', num1 = 3, markObj = { myName: 'Mark', myAge: 42 };

//you can use allthe different tyeps of string concatenation, interloation, variable value, etc 
// to print to the screen.
console.log(mark + 'has' + num1 + ' ' + `${markObj.myName} shaped ${markObj.myAge} robots`);

num1 = 'Now I\'m a string!';
console.log(num1);

markObj.address = '111 Main st.';

console.log(markObj.address);

let str4 = '5';
let num4 = 5;
if (str4 === num4) {
  console.log(`== - The str4 and the num4 are EQUAL!`);
}
else {
  console.log("=== - The string and number aren't equal.");
}


// truthy falsie
let str5 = "";
if (false || null || undefined || 0 || -0 || -0n || NaN || str5) {
  console.log('There is some truth(y) to those claims.');
}
else {
  console.log('All those values were false!');
}

console.log("Now for conversion");
console.log(String(5));//"5"
console.log(Number("5"));//5
console.log(Number("five"));//NaN
console.log(Number("null"));//NaN
console.log(Number(null));// null
console.log(Number(true));//1
console.log(Number(false));// 0

console.log("Now for booleans!");
console.log(Boolean(0));//false
console.log(Boolean(null));//false
console.log(Boolean(undefined));//false
console.log(Boolean(NaN));//false
console.log(Boolean("string"));//true
console.log(Boolean(""));//false
console.log(Boolean(1));//true
console.log(Boolean(" "));//true
// console.log(Boolean());//

console.log("Now for Maps");
let myMap = new Map();
myMap.set(1, 1000);
myMap.set(2, '1111');
myMap.set('3', '2222');
myMap.set('four', 3333);
myMap.set(false, true);

let myFalse = false;
myMap.set(myFalse, true);

myMap.forEach(x => console.log(x));
console.log(myMap.get('3'));
console.log(`The key 'false' is => ${myMap.get(false)}`);
console.log(`The key 'myFalse' is => ${myMap.get(myFalse)}`);
myMap.set(false, false);
console.log("resettign the values")
console.log(`The key 'false' is => ${myMap.get(false)}`);
console.log(`The key 'myFalse' is => ${myMap.get(myFalse)}`);

let myWmap = new WeakMap();
let obj1 = { myName: "Mark", age: 42 };
let obj2 = { myName: "Mark1", age: 43 };
let obj3 = { myName: "Mark2", age: 44 };

myWmap.set(obj1, "this is the value of the obj1");
myWmap.set(obj2, "this is obj2");
myWmap.set(obj3, "this is obj3");
// 
// myWmap.forEach(x => console.log(x));

console.log(myWmap);//tnis will print out the whole weakmap
// console.log(myWmap[2].value);// you cannot get values back out of hte weakmap

console.log(obj1)
let stringifiedObj1 = JSON.stringify(obj1);
console.log(stringifiedObj1);
let parsedObj1 = JSON.parse(stringifiedObj1);
console.log(parsedObj1);

function myFunc1(v1, v2 = 5) {
  let newVar = v1 + v2;
  return newVar;
}

let result1 = myFunc1(5, " results are a string.");
console.log(`The result is ${result1}`);

let result2 = myFunc1(5);// you can call a function with fewer args that there are parameters.
console.log(`THe result2 is ${result2}`);

//function expression
let myFunc2 = function (v1) {
  return v1 ** 5;
}
let r1 = myFunc2(2);
let r2 = myFunc2;

console.log(`The r1 is ${r1}`);
console.log(`The r2 is ${r2(3)}`);
console.log(`The r2 is ${myFunc2(3)}`);

// function expression using arrow syntax.
let myFunc3 = (x) => { return x += x; }

function myFunc4(x) {
  return x + x;
}

console.log(myFunc3(5));
console.log(myFunc4(5));

function myFunc5(someNumber, callbackfunc) {
  let newVar = callbackfunc(someNumber);
  return newVar;
}

function myFunc6(x) {
  return ++x;
}

let r3 = myFunc5(5, myFunc6);
console.log(`R3 is => ${r3}`);

let r4 = myFunc5(5, (x) => x ** x);
console.log(`R3 is => ${r4}`);

//IIFE is a function that is envoked as soon as the program reaches it.
(/*your function logic*/ () => console.log(2 ** 2))();

//scope and closure is WILD!
let myFunc7 = (x) => {
  return (y) => x + y;
}

let r5 = myFunc7();
console.log(`r5 is ${r5}`);
let r6 = r5(10);
console.log(`r6 is ${r6}`);

try {
  throw new SyntaxError("Thrrr was an errrrrr.");
}
catch (err) { console.log(err); }

localStorage.setItem(1, JSON.stringify(obj1));
let myGuy = localStorage.getItem(1);
console.log(myGuy);
console.log(myGuy.age);

let myGuy2 = JSON.parse(myGuy);// you must parse the string to get the JSON object and access the properties.
console.log(myGuy2.age);

sessionStorage.setItem(1, JSON.stringify(obj1));
let myGuy3 = sessionStorage.getItem(1);
console.log(myGuy3);
console.log(myGuy3.age);

let myGuy4 = JSON.parse(myGuy3);// you must parse the string to get the JSON object and access the properties.
console.log(myGuy4.age);



