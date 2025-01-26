// ------------- 1 ЗАДАНИЕ ---------------------------------------------

// function basicOperation(operation, value1, value2) {

//     switch (operation) {
//         case '+':
//             return value1 + value2;
//         case '-':
//             return value1 - value2;
//         case '*':
//             return value1 * value2;
//         case '/':
//             return value1 / value2;
//         default:
//             return "Ошибка! Данный оператор не предусмотрен!"
//     }
// }

// let operation = prompt('Введите операцию для двух операндов: ', '+');
// let value1 = Number( prompt('Введите первый операнд: ', '1') );
// let value2 = Number( prompt('Введите второй операнд: ', '2') );

// let result = basicOperation(operation, value1, value2);

// alert(`Результат: ${result}`);

//--------------- 2 ЗАДАНИЕ ------------------------------------------------

// function sumCubes(n) {
    
//     let arrCubNum = getNumsN(n);
//     let result = 0;
    
//     arrCubNum.forEach( num => result += Math.pow(num, 3) );
    
//     return result;
// }


// function getNumsN(n) {

//     let arr = [];

//     while( n != 0 ) {
//         arr.push(n);

//         if (n < 0) {
//             n++;
//             continue;
//         }
        
//         n--;
//     }

//     return arr;
// }


// let numCub = Number( prompt('Введите число n: ', 3) );
// let result = sumCubes(numCub);

// alert(`Конечный результат: ${result}`);

// --------------- 3 ЗАДАНИЕ ----------------------------------------------

// function meanNumber(arrNum) { 

//     return (arrNum.reduce( (sum, current) => sum + current)) / arrNum.length;
// }

// let arrNum = [];
// let i = 0;
// let num;

// do {
//     i++;
//     num = Number( prompt(`Введите ${i} элемент массива: `, '0') );
//     arrNum.push(num);
// } while (num);


// let result = meanNumber(arrNum);
// alert( result );

//----------------- 4 ЗАДАНИЕ -------------------------------------------------

function reverseStr(str) {
    
    str = str.split('');
    let filteredArray = str.filter(element => /[a-zA-Z]/.test(element));
   
    return filteredArray.reverse().join('');
}


let str1 = 'JavaScript';
let str2 = "JavaScr53э? ipt"

alert( reverseStr(str1) );
alert( reverseStr(str2) );


//----------------- 5 ЗАДАНИЕ -------------------------------------------------

// function repeatStr(n, s) {

//     for (let i = 0; i < n; i++)
//         console.log(s);        
    
// }

// let n = +prompt('Введите кол-во повторений строки: ', '0');
// let s = prompt('Введите строку: ', '');

// repeatStr(n, s);

//------------------ 6 ЗАДАНИЕ ------------------------------------------------

// function containsArray(arr1, arr2) {

//     let arr3 = [];
    
//     for (let i = 0; i < arr1.length; i++) {

//         if(!arr2.includes(arr1[i]))
//             arr3.push(arr1[i]);
        
//     }

//     return arr3;
// }

// let arr1 = ['Апельсин', 'Морковь', 'Яблоко', 'Груша', 'Слива'];
// let arr2 = ['Морковь', 'Картошка', 'Свекла', 'Слива', 'Петрушка'];

// alert( containsArray(arr1, arr2) );
