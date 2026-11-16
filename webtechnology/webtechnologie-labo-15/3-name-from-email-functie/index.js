const prompt = require('prompt-sync')();




function nameFromEmail(userEmail)
{
    let substractedStrg = userEmail.slice(0, userEmail.indexOf('@'));
    let output = (substractedStrg.split('.'));
    output[0] = output[0].toUpperCase();
    output[1] = output[1].toUpperCase();

    return output;
}

let userEmail;
let output;


do{
    userEmail = prompt("Geef uw email: ");
    if (userEmail === "")
    {
        break ;
    }
    else
    {
        output = nameFromEmail(userEmail);
        console.log(`De eigenaar van ${userEmail} heet ${output[0]} ${output[1]}`);
    }

} while(userEmail != "");

