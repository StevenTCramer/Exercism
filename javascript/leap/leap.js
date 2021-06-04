export const isLeap = (aYear) => aYear % 4 === 0 && aYear % 100 !== 0 || aYear % 400 === 0;

// export const isLeap = (aYear) => {
//   // isDivisibleBy4 And isNotDivisibleBy100 || isDivisibleBy400
//   const isDivisibleBy4 = () => aYear % 4 === 0;
//   const isNotDivisibleBy100 = () => aYear % 100 !== 0;
//   const isDivisibleBy400 = () => aYear % 400 === 0;
//   return isDivisibleBy4() && isNotDivisibleBy100() || isDivisibleBy400();
  
// }

// export const isLeap = (aYear) => {
//   return (aYear % 4 === 0) ?
//     aYear % 100 === 0 ?
//     (aYear % 400 === 0) :
//     true :
//     false;
// }

// export const isLeap = (aYear) => {
//   let isLeapYear = false;
//   const isDivisibleBy4 = aYear % 4 === 0;
//   if (isDivisibleBy4) {
//     isLeapYear = true;
//     const isDivisibleBy100 = aYear % 100 === 0;

//     if (isDivisibleBy100) {
//       const isDivisibleBy400 = aYear % 400 === 0;
//       if (!isDivisibleBy400) {
//         isLeapYear = false;
//       }
//     }
//   };

//   return isLeapYear;
// }