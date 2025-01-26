// ------------ 1 ЗАДАНИЕ --------------------
{
    console.log('1 task');

    const set = new Set([1,1,2,3,4]);

    console.log(set);
}
// ------------ 3 ЗАДАНИЕ -------------------- 
{
    console.log('3 task');

    const name = 'Lydia';
    age = 21;

    console.log(delete name);
    console.log(delete age);
}
// ------------ 4 ЗАДАНИЕ ---------------------
{
    console.log('4 task');

    const numbers = [1, 2, 3, 4, 5];
    const [y] = numbers;

    console.log(y);
} 
// ------------- 5 ЗАДАНИЕ --------------------
{
    console.log('5 task');

    const user = { name: 'Lydia', age: 21 };
    const admin = { admin: true, ...user };

    console.log(admin);
}
// ------------- 6 ЗАДАНИЕ ---------------------
{
    console.log('6 task');

    const person = { name: 'Lydia' };

    Object.defineProperty(person, 'age', {value: 21});

    console.log(person);
    console.log(Object.keys(person));
}
// ------------- 7 ЗАДАНИЕ ---------------------
{
    console.log('7 task');

    const a = {};
    const b = { key: 'b' };
    const c = { key: 'c' };

    a[b] = 123;
    a[c] = 456;

    console.log(a[b]);
    console.log(a[c]);
    console.log(a);
}
// -------------- 8 ЗАДАНИЕ ---------------------
{
    console.log('8 task');

    let num = 10;

    const increaseNumber = () => num++;
    const increasePassedNumber = number => number++;

    const num1 = increaseNumber();
    const num2 = increasePassedNumber(num1);

    console.log(num1);
    console.log(num2);
}
// -------------- 9 ЗАДАНИЕ ----------------------
{
    console.log('9 task');

    const value = { number: 10 };

    const multiply = (x = { ...value }) => {
        console.log( x.number *= 2 );
    };

    multiply();
    multiply();
    multiply(value);
    multiply(value);
}
// -------------- 10 ЗАДАНИЕ ---------------------
{
    console.log('10 task');

    [1, 2, 3, 4].reduce( (x, y) => console.log(x, y));
}
