let initialCapital = 100000;
let interestRate = 0.02;
let numberOfYears = 7;

let endCapitalWithInterest = initialCapital * (1 + interestRate ) ** numberOfYears;

console.log(`Op een periode van ${numberOfYears} yaar stijgt je bezit van ${initialCapital} naar ${endCapitalWithInterest.toFixed(0)}.`)

console.log(`Dit met een rentevoet van ${interestRate}`);