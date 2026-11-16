function printTextBox(str) {
//   console.log("/****************\\");
let borderTopAndBottom = "*".repeat(str.length + 4);

  console.log("/" + borderTopAndBottom + "\\");

  console.log("| " + str.toUpperCase() + " |");

  console.log("\\" + borderTopAndBottom + "/");
//   console.log("\\****************/");
}

printTextBox("Welcome back");
printTextBox("what's up?");
printTextBox("get started");
