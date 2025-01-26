// ----------------- 1 ЗАДАНИЕ --------------------

let setProduct = new Set();

setProduct.add('Яблоко');
setProduct.add('Груша');

const addProductb = document.getElementById('addProduct');
addProductb.addEventListener('click', addProduct);

function addProduct() {
    let newProduct = prompt('Какой товар добавить? ', '');
    return setProduct.add(newProduct);
}


const deleteProductb = document.getElementById('deleteProduct');
deleteProductb.addEventListener('click', deleteProduct);

function deleteProduct() {
    let delProduct = prompt('Какой товар удалить? ', '');

    if (!setProduct.has(delProduct))
        return alert('Такого товара нет!');

    return setProduct.delete(delProduct);
}


const hasProductb = document.getElementById('hasProduct');
hasProductb.addEventListener('click', hasProduct);

function hasProduct() {
    let hsProduct = prompt('Введите товар для проверки на наличие: ', '');
    if (!setProduct.has(hsProduct)) {
        return alert(`Товар ${hsProduct} не найден!`);
    }

    return alert(`Товар ${hsProduct} найден!`);
}


const sizeProductb = document.getElementById('sizeProduct');
sizeProductb.addEventListener('click', sizeProduct);

function sizeProduct() {
    alert(`Кол-во элементов set: ${setProduct.size}`);
}

// ------------------- 2 ЗАДАНИЕ --------------------------------------------

let listOfStudents = new Set();

let stdt1 = {
    numberGradeBook: 1,
    numberGroup: 3,
    name: 'Иванов Алексей Владимирович',
};

let stdt2 = {
    numberGradeBook: 2,
    numberGroup: 5,
    name: 'Печугина Елена Артемовна',
};

let stdt3 = {
    numberGradeBook: 3,
    numberGroup: 3,
    name: 'Касач Андрей Владиславович',
};

listOfStudents.add(stdt1);
listOfStudents.add(stdt2);
listOfStudents.add(stdt3);


const addStudentsB = document.getElementById('addStudent');
addStudentsB.addEventListener('click', addStudents);

function addStudents() {

    let student = {}

    student.numberGradeBook = Number( prompt('Введите номер зачетки студента: ', 0) );
    student.numberGroup = Number( prompt('Введите номер группы студента: ', 0) );
    student.name = Number( prompt('Введите ФИО студента: ', '') );

    return listOfStudents.add(student);
}


const deleteStudentB = document.getElementById('deleteStudent');
deleteStudentB.addEventListener('click', deleteOfStudent);

function deleteOfStudent() {
    let delStudent = Number ( prompt('Для удаления введите номер зачетки студента: ', 0) );
    
    listOfStudents.forEach( el => {
        if(el.numberGradeBook == delStudent)
            listOfStudents.delete(el);
    })

    listOfStudents.delete(delStudent);
    console.log(listOfStudents);
}


const filteredInGroupB = document.getElementById('filteredInGroup');
filteredInGroupB.addEventListener('click', filteredInGroup);

function filteredInGroup() {
    let numOfGroup = Number( prompt('Введите какую группу вывести: ', 1) );
    if (numOfGroup < 1) {
        return alert('Таких групп нет!');
    }

    let studentsSorted = Array.from(listOfStudents).sort((a, b) => a.numberGradeBook - b.numberGradeBook);
    studentsSorted.forEach(item => {
        if (item.numberGroup == numOfGroup) {
            alert(`${item.name}: ${item.numberGroup}`)
        }
});

    // for (let element of (listOfStudents)) {
    //     if (element.numberGroup == numOfGroup) {
    //         alert(JSON.stringify(element, null, 2));
    //     }
    // }
}


const filteredOfNumberGradeBookB = document.getElementById('filteredOfNumberGradeBook');
filteredOfNumberGradeBookB.addEventListener('click', filteredOfNumberGradeBook)

function filteredOfNumberGradeBook() {
    
    let studentsSorted = Array.from(listOfStudents).sort((a, b) => a.numberGradeBook - b.numberGradeBook);

    for (const element of studentsSorted) {
        alert(`Имя: ${element.name}. Номер зачетки: ${element.numberGradeBook}`);
    }
}

console.log(listOfStudents);



// ------------------- 3 ЗАДАНИЕ --------------------------------------

let listOfProduct = new Map();

let prod1 = {
    id: 'TV',
    name: 'Телевизор',
    numberProduct: 9,
    price: 2999,
};

let prod2 = {
    id: 'Cleaner',
    name: 'Пылесос',
    numberProduct: 25,
    price: 899,
};

listOfProduct.set(prod1.id, prod1);
listOfProduct.set(prod2.id, prod2);


let addTvr = document.getElementById('addTovar');
addTvr.addEventListener('click', addTovar);

function addTovar() {
    let id = prompt('Введите id для товара: ', '');
    let name = prompt('Введите название товара: ', '');
    let numberProduct = Number( prompt('Введите кол-во товара: ', 1) );
    let price = Number( prompt('Введите цену товара: ', 1) );

    let newProduct = {
        id: id,
        name: name,
        numberProduct: numberProduct,
        price: price,
    };

    return listOfProduct.set(newProduct.id, newProduct);
}

console.log(listOfProduct);

let deleteTvrId = document.getElementById('deleteTovarId');
deleteTvrId.addEventListener('click', deleteTovarId);

function deleteTovarId() {
    let deleteProductId = prompt('Какой товар удалить? (введите id товара)', '');

    if (!listOfProduct.has(deleteProductId)) {
        return alert(`Товар с id ${deleteProductId} не найден!`);
    }
    else {
        alert(`Товар с id ${deleteProductId} удален!`);
        return listOfProduct.delete(deleteProductId);
    }
}


let deleteTvrName = document.getElementById('deleteTovarName');
deleteTvrName.addEventListener('click', deleteTovarName);

function deleteTovarName() {
    let deleteProductName = prompt('Какой товар удалить? (введите название товара)', '');

    listOfProduct.forEach(product => {
        if (product.name == deleteProductName) {
            alert(`Товар ${product.name} удален!`);
            listOfProduct.delete(product.id)
            return;
        }
    })

    return alert(`Товара ${deleteProductName} нет в наличии!`);

    // if (listOfProduct.) {
    //     alert(`Товар ${deleteProductName} не найден!`);
    //     return;
    // }
    // else {
    //     alert(`Товар ${deleteProductName} удален!`);
    //     return listOfProduct.delete(deleteProductName);
    // }
}


let changeQntt = document.getElementById('changeQuantity');
changeQntt.addEventListener('click', changeQuantity);

function changeQuantity() {
    let changeQuantityProduct = prompt('Для какого товара меняем кол-во товара?', '');

    listOfProduct.forEach(product => {
        if (product.name == changeQuantityProduct) {
            let newCount = Number( prompt(`Введите новое кол-во товара ${changeQuantityProduct}:`, 0) );

            product.numberProduct = newCount;

            alert(`Теперь кол-во товара ${changeQuantityProduct} состовляет: ${newCount}`);
            return;
        }
    })

    return alert(`Товара ${changeQuantityProduct} нет в наличии!`);

    // if (!listOfProduct.has(changeQuantityProduct)) {
    //     alert(`Товар ${changeQuantityProduct} не найден!`);
    // }
    // else {
    //     let newCount = Number( prompt(`Введите новое кол-во товара ${changeQuantityProduct}:`, 0) );

    //     listOfProduct.forEach(element => {
    //         if (element.name == changeQuantityProduct) {
    //             element.numberProduct = newCount;
    //             alert(`Теперь кол-во товара ${changeQuantityProduct} состовляет: ${newPrice}`);
    //         }
    //     });
        
    // }
}


let changePrc = document.getElementById('changePrice');
changePrc.addEventListener('click', changePrice);

function changePrice() {
    let changePriceProduct = prompt('Для какого товара изменить цену?', '');


    listOfProduct.forEach(product => {
        if (product.name == changePriceProduct) {
            let newPrice = Number( prompt(`Введите новую цену товара ${changePriceProduct}:`, 0) );

            product.price = newPrice;

            return alert(`Теперь цена товара ${changePriceProduct} состовляет: ${newPrice}`);
        }
    })

    return alert(`Товара ${changePriceProduct} нет в наличии!`);

    
    // if (!listOfProduct.has(changePriceProduct)) {
    //     alert(`Товар ${changePriceProduct} не найден!`);
    // }
    // else {
    //     let newPrice = Number( prompt(`Введите новую цену для товара ${changePriceProduct}:`, 0) );

    //     listOfProduct.forEach(element => {
    //         if (element.get() == changePriceProduct) {
    //             element.price = newPrice;
    //             alert(`Цена для товара ${changePriceProduct} теперь равна ${newPrice}`);
    //         }
    //     });
        
    // }
}

const countAllProduct = document.getElementById('knowCountAllProduct');
countAllProduct.addEventListener('click', knowCountAllProduct);

function knowCountAllProduct() {
    
    let result = 0;

    listOfProduct.forEach(product => {
        result += product.numberProduct;
    })

    alert(`Всего имеется ${result} продуктов`);
}

const sumPriceAllProduct = document.getElementById('knowSumPriceAllProduct');
sumPriceAllProduct.addEventListener('click', knowSumPriceAllProduct);

function knowSumPriceAllProduct() {
    
    let result = 0;

    listOfProduct.forEach(product => {
        result += product.price;
    })

    alert(`Общая стоимость всех товаров состовляет ${result} руб.`);
}

// for (let item of listOfProduct.entries()) {
//     alert(item);
    
// }


// --------------- 4 ЗАДАНИЕ ---------------------------------------

let weakMap = new WeakMap();

function process(obj) {
    if (!weakMap.has(obj)) {
        
        let result = obj.value * 2;
        weakMap.set(obj, result);
        alert(`Объект ${obj.name} был закеширован!`);
    }

    return weakMap.get(obj);
}

let obj1 = { name: 'obj1', value: 5};
let obj2 = { name: 'obj2', value: 15};

let result1 = process(obj1); // Добавляем
let result2 = process(obj1); // Из кеша

let result3 = process(obj2); // Добавляем
let result4 = process(obj2); // Из кеша


