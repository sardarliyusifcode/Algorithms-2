let numbers = [2, 0, 4, 64, 2, 5, 34, 24, 1, 563, 42];

let min = numbers[0];
let minIndex = 0;
let max = numbers[0];
let maxIndex = 0;

for (let i = 0; i < numbers.length; i++) {
  if (numbers[i] <= min) {
    min = numbers[i];
    minIndex = i;
  } else if (numbers[i] >= max) {
    max = numbers[i];
    maxIndex = i;
  }
}
numbers[minIndex] = max;
numbers[maxIndex] = min;
console.log(numbers);

// ***************************** TASK 2 ***********************************

// let num = 1023456789;
// let i;
// let numZero = 0;
// let numOne = 0;
// let numTwo = 0;
// let numThree = 0;
// let numFour = 0;
// let numFive = 0;
// let numSix = 0;
// let numSeven = 0;
// let numEight = 0;
// let numNine = 0;

// if(num > 9999999999){
//   // Cunki ededde 11 reqem varsa avtomatiski biri tekrar olur
//   console.log("Tekrar reqem var");
// }else{
//   while(num > 0){
//     i = num % 10;
//     if (i == 0) {
//       numZero++;
//     }else if (i == 1){
//       numOne++;
//     }else if (i == 2){
//       numTwo++;
//     }else if (i == 3){
//       numThree++;
//     }else if (i == 4){
//       numFour++;
//     }else if (i == 5){
//       numFive++;
//     }else if (i == 6){
//       numSix++;
//     }else if (i == 7){
//       numSeven++;
//     }else if (i == 8){
//       numEight++;
//     }else if (i == 9){
//       numNine++;
//     }
//     num = ( num - i) / 10;
//   }

//   if( numZero > 1 || numOne > 1 || numTwo > 1 || numThree > 1 || numFour > 1 || numFive > 1 || numSix > 1 || numSeven > 1 || numEight > 1 || numNine > 1){
//     console.log("Tekrar reqem var");
//   }else{
//     console.log("Hamisi ferqldiir");
//   }
// }
