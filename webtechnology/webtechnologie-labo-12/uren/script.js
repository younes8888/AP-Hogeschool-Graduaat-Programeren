let currentTime = 14;
let numberOfHoursToAdd = 33;

let newCurrentTime = (currentTime + numberOfHoursToAdd) % 24;

console.log(`Het is nu ${currentTime}`);
console.log(`Over ${numberOfHoursToAdd} is het ${newCurrentTime}`);