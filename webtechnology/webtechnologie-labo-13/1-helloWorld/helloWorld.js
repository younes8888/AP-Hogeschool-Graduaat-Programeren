
let isValid = true;

let firstName = prompt("Wat is je voornaam? ");
let lastName = prompt("Wat is je achternamm? ");
let age = parseInt(prompt("hoe oud ben je? "));


if (firstName == "" || lastName == "") {
    isValid = false;
  console.log("Vul zowel voornaam als achternaam in!");
}

if (age > 60 || age < 12 || isNaN(age)) {
    isValid = false;
  console.log("U behoort niet tot de gezochte leeftijdsklasse!");
}

if (isValid)
{
      console.log(`Welkom ${firstName} ${lastName}, je bent ${age} jaar oud.`);
}

