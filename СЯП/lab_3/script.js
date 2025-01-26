// // ------------ 1 ЗАДАНИЕ -----------------------------------

// let arr1 = [1, [1, 2, [3, 4]], [2, 4]];
// let arr2 = [5, [6, 7], [6, [7, 9]]];


// let unionArr = (arr) => {
//     return arr.reduce((accum, item) => {
//         if(Array.isArray(item)) {
//             accum.push(...unionArr(item));
//         } else {
//            accum.push(item);
//         }
//         return accum;
//     }, []);
// }

// // let arr3 = [arr1, arr2].reduce((accum, item) => accum.concat(item));
// // arr3 = arr3.reduce((accum, item) => {

// //     if(Array.isArray(item)) {
// //         item.forEach(element => {
// //             accum.push(element);
// //         });

// //     } else {
// //         accum.push(item);
// //     }
// //     return accum;
// // }, []);

// let arr3 = unionArr(arr1.concat(arr2));


// console.log(arr3);

// --------------- 2 ЗАДАНИЕ -------------------------------------

// let arr1 = [1, [1, 2, [3, 4, [1, 1]]], [2, 4]];

// let sumArr = (arr) => {
//     return arr.reduce((accum, item) => {
//         if (Array.isArray(item)) {
//             accum += sumArr(item);
//         } else {
//             accum += item;
//         }
//         return accum;
//     })
// }

// console.log(sumArr(arr1));

// ----------------- 3 ЗАДАНИЕ ------------------------------------

// let arrOfStudents = [
//     {name: 'Ivan', age: 17, groupId: 1},
//     {name: 'Vlad', age: 19, groupId: 2},
//     {name: 'Lesha', age: 19, groupId: 1},
//     {name: 'Anna', age: 16, groupId: 2},
//     {name: 'Ira', age: 16, groupId: 1},
//     {name: 'Artem', age: 18, groupId: 5},
//     {name: 'Andrey', age: 19, groupId: 4},
//     {name: 'Lera', age: 19, groupId: 3},
//     {name: 'Maria', age: 18, groupId: 2},
//     {name: 'Petr', age: 16, groupId: 2},
//     {name: 'John', age: 20, groupId: 5},
//     {name: 'Sergey', age: 16, groupId: 4},
//     {name: 'Natalia', age: 17, groupId: 3},
// ];


// function convertToObjectStudents(arrStd) {
//     return arrStd.reduce((accum, item) => {
//         if(item.age > 17) {
//             if (!accum[item.groupId])
//                 accum[item.groupId] = [];
            
//             accum[item.groupId].push(item);
//         }

//         return accum;

//     }, {})
// }

// let result = convertToObjectStudents(arrOfStudents);

// console.log(result);
// console.log(typeof(result));

// ------------------- 4 ЗАДАНИЕ ----------------------------------

// let str1 = 'ABC';


// function convertStrToInt(str) {
//     str = str.split('');
//     let result = '';

//     str.forEach(el => {
//         result += el.charCodeAt();
//     });

//     return result;
// }

// function replaceSevenToOne(num) {
//    num = num.split('');
//    let result = '';
    
//     num.forEach((item) => {
//         if (item != '7') {
//             result += item;
//         } else {
//             result += '1';
//         }
//     })

//     return result;
// }

// let total1 = convertStrToInt(str1);
// alert(total1);
// let total2 = replaceSevenToOne(total1);
// alert(total2);

// alert(Number(total1) - Number(total2));

// --------------- 5 ЗАДАНИЕ -------------------------------

// function assignObjects(...objs) {
//     let obj = {};
//     objs.forEach((item) => {
//        Object.assign(obj, item);
//     });

//     return obj;
// }

let obj1 = {
    a: 1,
    b: 2,
};

let obj5 = {};

Object.assign(obj5, obj1);

obj5.a = 10;

alert(obj1.a);

// let obj2 = {
//     c: 3,
// };

// let assignObj1 = assignObjects(obj1, obj2);

// for (const key in assignObj1) {
//     alert(`Ключ: ${key}`);
//  }

// let obj3 = {
//     a: 3,
//     c: 4,
// }

// let assignObj2 = assignObjects(obj1, obj2, obj3);

// for (const key in assignObj2) {
//     alert(`Ключ: ${key}`);
// }

// ---------------- 6 ЗАДАНИЕ -------------------------------

// function buildTower(floors) {
//     let tower = [];

//     for (let i = 0; i < floors; i++) {
//       let spaces = ' '.repeat(floors - i - 1);
//       let stars = '*'.repeat(2 * i + 1);
//       tower.push(spaces + stars + spaces);
//     }

//     return tower;
//   }
  
//   let floors = 9;
//   let tower = buildTower(floors);
//   console.log(tower);