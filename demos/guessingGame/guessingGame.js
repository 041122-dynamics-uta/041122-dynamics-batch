/* The user will gues a number 0-100.
the user geta 10 guesses
We will tell them too high too low 
just right.
We will also list the numbers that they've guessed below.

after the is over we present a button to reset the game.
 */
let submitButton = document.getElementById('submit');
let result = document.getElementById('result');
let list = document.getElementById('guessList');
let guess = document.getElementById('guess');
let body = document.body;
let randomNum = randomNumberGenerator();
let resetButton;
let userGuess = -1;

function resetPage() {
  //logic to reset the whole page to starting values.
  // list.innerText = '';// TODO - this isn't clearing the innerHTML
  // resetButton.remove();
  location.reload();
}

function randomNumberGenerator() {
  return Math.floor(Math.random() * 100);
}

function tooHigh() {
  // console.log(`in the toohigh()`);
  //tell tehm they are too tooHigh
  result.innerText = 'Sorry, That number is too high.';
  list.innerHTML += `<li>${userGuess}</li>`;

}

function tooLow() {
  // console.log(`in the toolow()`);
  result.innerText = 'Sorry, That number is too low.';
  list.innerHTML += `<li>${userGuess}</li>`;

}

function justRight() {
  // console.log(`in the justright()`);
  result.innerText = 'What did Goldilocks say?... Juuust Riiiight';
  list.innerHTML += `<li>${userGuess}</li>`;
}

//function to create the reset submitButton
function createResetButton() {
  body.innerHTML += `<button type="reset" id="resetId">Replay the game?</button>`
  resetButton = document.getElementById('resetId');
  resetButton.addEventListener('click', (e) => {
    e.preventDefault();
    resetPage();
    toggleSubmitButton();
  });
}

function resetTheGuessBox() {
  guess.value = '';
}

function howManyGuesses() {
  return list.children.length;
}

function tenGuesses() {
  result.innerText = 'Sorry, You\'ve exhausted your 10 guesses ';
}

function toggleSubmitButton() {
  submitButton.disabled = !submitButton.disabled;
}


//need eventlistener to reset the page.

submitButton.addEventListener('click', (e) => {
  //stop the page from reloading automatically
  e.preventDefault();
  //get the number from the user
  userGuess = guess.value;
  //console.log(`The user guess was ${userGuess}`);

  //compare the number to the randomly selected number
  // alert the user that they were high or low or correct
  // by change the text of the result h2
  // add the guess they made in guesslist.
  if (userGuess > randomNum) {
    //if too high
    tooHigh();
    resetTheGuessBox();
    // check if they've guess 10 times. 
    if (howManyGuesses() === 10) {
      tenGuesses();
      createResetButton();
      toggleSubmitButton();
    }
    // if so, end the game
  }
  else if (userGuess < randomNum) {
    //if too low
    tooLow();
    // check if they've guess 10 times
    resetTheGuessBox();
    if (howManyGuesses() === 10) {
      tenGuesses();
      createResetButton();
      //disable the submit number button
      toggleSubmitButton();
    }
  }
  else {
    // juuuuuust riiiight. 
    justRight();
    //offer the option of restarting the game
    // adding a new button at the bottom of the page to reset.
    createResetButton();
    toggleSubmitButton();
  }
});


