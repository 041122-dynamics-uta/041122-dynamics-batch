
// let myform = document.getElementsByTagName('form');

window.addEventListener('load', () => {
  console.log("load happened");
  for (let i = 0; i < 1000000000; i++) { }
});

document.addEventListener('DOMContentLoaded', () => {
  console.log('DOM fully loaded and parsed');
  for (let i = 0; i < 1000000000; i++) { }
});

document.addEventListener('readystatechange', (e) => {
  console.log(`readystate is ${document.readyState}.`);
  for (let i = 0; i < 1000000000; i++) { }
});

// function mydate(event, form) {
//   event.preventDefault();
//   // console.log('This is a message');
//   //var form = document.querySelector('form').elements;
//   console.log(form);
//   console.log('this is a message');
//   // console.log(form.checkbox1.value);
// }

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