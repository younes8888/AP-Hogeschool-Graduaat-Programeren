let year = parseInt(prompt("Geef het jaartal in: "));

if (year % 4 === 0)
{
  if (year % 100 === 0)
  {
    if (year % 400 === 0)
    {
      console.log(`${year} is een schrikkeljaar.`);
    }
     else
    {
      console.log(`${year} is geen schrikkeljaar.`);
    }
  }
   else
  {
    console.log(`${year} is een schrikkeljaar.`);
  }  
}
else 
{
  console.log(`${year} is geen schrikkeljaar.`);
}
