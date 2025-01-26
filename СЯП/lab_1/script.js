// ----- 1 ЗАДАНИЕ --------
// let a = 5;              // numbber
// let name = "Name";      // string
// let i = 0;              // number
// let double = 0.23;      // number
// let result = 1/0;       // number
// let answer = true;      // boolean
// let no = null;          // null

// ----- 2 ЗАДАНИЕ ------------

// function multA() {
//     let sideA = prompt("Введите сторону А: ", 45);
//     let sideB = prompt("Введите сторону B: ", 21);

//     let resultMultA = sideA * sideB;

//     return resultMultA;
// }

// alert( multA() );

// ----- 3 ЗАДАНИЕ -------------

// let i = 2;
// let a = ++i;    // 3
// alert(a);
// let b = i++;    // 3
// alert(b);

// ------ 4 ЗАДАНИЕ -------------

// let a = "Котик" == "котик" ? alert("Котик == котик. Выражение верное") : alert("Котик != котик. Выражение не верное");
// let b = "Котик" == "китик" ? alert("Котик == китик. Выражение верное") : alert("Котик != китик. Выражение не верное");
// let с = "Кот" == "Котик" ? alert("Кот == Котик. Выражение верное") : alert("Кот != Котик. Выражение не верное");
// let d = "Привет" == "Пока" ? alert("Привет == Пока. Выражение верное") : alert("Привет != Пока. Выражение не верное");
// let e = 73 == "53" ? alert("73 == '53'. Выражение верное") : alert("73 != `53`. Выражение не верное");
// let f = false == 0 ? alert("false == 0. Выражение верное") : alert("false != 0. Выражение не верное");
// let g = 54 == true ? alert("54 == true. Выражение верное") : alert("54 != true. Выражение не верное");
// let h = 123 == false ? alert("123 == false. Выражение верное") : alert("123 != false. Выражение не верное");
// let j = true == "3" ? alert("true == '3'. Выражение верное") : alert("true != '3'. Выражение не верное");
// let k = '3' == 3 ? alert("'3' == 3. Выражение верное") : alert("'3' != 3. Выражение не верное");
// let l = 3 == '5мм' ? alert("3 == '5мм'. Выражение верное") : alert("3 != '5мм'. Выражение не верное");
// let w = 8 == '-2' ? alert("8 == '-2'. Выражение верное") : alert("8 != '-2'. Выражение не верное");
// let r = 34 == '34' ? alert("34 == '34'. Выражение верное") : alert("34 != '34'. Выражение не верное");
// let t = null == undefined ? alert("null == undefined. Выражение верное") : alert("null != undefined. Выражение не верное");

// ------- 5 ЗАДАНИЕ --------------

// function inputNameTeacher() {

//     let nameTeacher = prompt("Введите имя преподавателя: ", 'Марина');

//     nameTeacher = nameTeacher.toUpperCase();

//     if (nameTeacher == "МАРИНА" || nameTeacher == 'МАРИНА ФЕДОРОВНА' || nameTeacher == 'КУДЛАЦКАЯ МАРИНА ФЕДОРОВНА') {
//         return alert("Введенные данные верные!");
//     }
        
//     return alert("Введенные данные не верные! Попробуйте в следующий раз");
// }


// inputNameTeacher();

// -------- 6 ЗАДАНИЕ --------------

// function passingTheExam() {

//     let isPassingRussian = confirm("Студент сдал русский язык?");
//     let isPassingMath = confirm("Студент сдал математику?");
//     let isPassingEnglish = confirm("Студент сдал английский язык?");

//     if (!(isPassingEnglish && isPassingMath && isPassingRussian)) {
//         return alert("Студента ожидает пересдача");
//     }
//     if (!isPassingEnglish && !isPassingMath && !isPassingRussian) {
//         return alert("Студента ожидает отчисление");
//     }

//     return alert("Студент будет успешно переведен на следующий курс");
// }

// passingTheExam();

// ---------- 7 ЗАДАНИЕ ----------------

// alert(true + true);
// alert(0 + '5');
// alert(5 + 'мм');
// alert(8/Infinity);
// alert(9 * '\n9');
// alert(null - 1);
// alert('5px' - 3);
// alert(true - 3);
// alert(7 || 10);

// ---------- 8 ЗАДАНИЕ --------------------

// function oddNumber() {

//     for(let i = 1; i <= 10; i++) {
//         if(evenNumber(i)) {
//             i = i + 2;
//             alert(i);
//             continue;
//         }

//         alert(i + 'мм');
//     }
// }

// function evenNumber(i) {
//     if(i % 2 ==0) 
//         return true;

//     return false
// }

// oddNumber();

// ----------- 9 ЗАДАНИЕ ------------------------

// function whatDayWeek() {

//     let dayOfWeek = {
//         1: 'Понедельник',
//         2: 'Вторник',
//         3: 'Среда',
//         4: 'Четверг',
//         5: 'Пятница',
//         6: 'Суббота',
//         7: 'Воскресенье',
//     }

//     let day = prompt("Введите номер дня недели: ", 1);
    
//     if(day < 1 || day > 7) 
//         return alert("Ошибка!");

//     alert(dayOfWeek[day]);

//     // let dayOfWeek = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота', 'Воскресенье'];

//     // let day = prompt("Введите номер дня недели: ", 1);

//     // if(day < 1 || day > 7) 
//     //     return alert("Ошибка!");

//     // alert( dayOfWeek[day - 1] );
// }

// whatDayWeek();

// -------- 10 ЗАДАНИЕ ----------------

// function func(a = 'Hyper', b, c) {

//     return a + b + c;
// }

// let a;
// let b = 'Word';
// let c = prompt("Введите 3-ий параметр: ", 'End');

// alert( func(a, b, c) );

// --------- 11 ЗАДАНИЕ --------------------

// let a = prompt("Введите значение а: ", 1);
// let b = prompt("Введите значение b", 1);

// // Function Declaration

// // function params(a, b) {
// //     if(a == b) {
// //         return a*4;
// //     }

// //     return a * b;
// // }



// // Function Expression

// // let params = function(a , b) {
// //     if(a == b) {
// //         return a*4;
// //     }

// //     return a * b;
// // }



// // Стрелочная функция

// let params = (a, b) => {
//     if(a == b) {
//         return a*4;
//     }

//     return a * b;
// }




// alert (params(a, b) );