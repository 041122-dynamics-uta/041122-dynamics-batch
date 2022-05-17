//http://api.icndb.com/jokes/random

let theDiv = document.getElementsByClassName('jokeCentral');

// Step 2.0 Create a function that you can assign to the 
// onreadystatechange property of the XML object
function myCallbackFunc() {
  console.log(`The readystate is ${this.readyState}.`);
  if (this.readyState == 4) {
    console.log(`The call was a success, but the status is ${this.status}`);
    console.log(this.responseText);
    console.log(JSON.parse(this.responseText));
    let ret = JSON.parse(this.responseText);//get the object as a variable
    console.log(ret.value.joke);
    console.log(JSON.parse(this.responseText).value.joke);
    // let theDiv = document.getElementsByClassName('jokeCentral');
    theDiv[0].innerHTML += `<p class="myClass">${ret.value.joke}</p>`;
    theDiv[0].innerHTML += `<p>${ret.value.joke}</p>`;

  }
  else {
    console.log("The call was not a success");
  }
}

//Step 1. Create the XMLHttpRequest object
let xhr1 = new XMLHttpRequest();

//Step 2.1 set the unternal variables of the object so that it can react
// appropriately when the call is made.
xhr1.onreadystatechange = myCallbackFunc;

//Step 3. open the connection
xhr1.open('GET', 'http://api.icndb.com/jokes/random');

// step 4. send the request.
xhr1.send();

console.log('The xmlhttprequests has had it\'s day....');

/**This is Fetch! */

fetch('http://api.icndb.com/jokes/random')
  .then(res => {
    if (!res.ok) {
      throw new Error("there was an error that I caught.");
    }
    console.log(`The FETCH response status is ${res.status}`);
    return res.json()
  })
  .then(p2 => console.log(`The Fetch joke is ==${p2.value.joke}`))
  .catch(err => console.log("there was an errorrrrrrrr"))

// another fetch 
fetch('http://api.icndb.com/jokes/random/5')
  .then(res => {
    if (!res.ok) {
      throw new Error("there was an error that I caught.");
    }
    console.log(`The FETCH response status is ${res.status}`);
    return res.json();
  })
  .then(p3 => {
    console.log(p3);
    return p3;
  })
  .then(p2 => //print all the jokes to a new div as h3 elements
  {
    //create the new the div element
    //console.log('sanity check')
    const newDiv = document.createElement('div');
    newDiv.classList += 'marksNewClass';
    //newDiv.innerText = 'what\'s doing on??'
    //document.body.appendChild(newDiv);

    // find a way to insert that div between the current div and the script
    //insert the new div without the jokes
    theDiv[0].insertAdjacentElement('afterend', newDiv);

    //insert the jokes into the new div
    for (let x = 0; x < p2.value.length; x++) {
      newDiv.innerHTML += `<h3>${p2.value[x].joke}</h3>`;
    }



  })
  .catch(err => console.log(`${err.message}`))
