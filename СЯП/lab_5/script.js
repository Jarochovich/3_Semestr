// -------------- 1 ЗАДАНИЕ -----------------------
{
    alert('Первый вариант')

    function makeCounter() {
        let currentCount = 1;

        return function() {
            return currentCount++;
        };
    }

    let counter = makeCounter();

    alert( counter() );
    alert( counter() );
    alert( counter() );

    let counter2 = makeCounter();

    alert( counter2() );
}

{
    alert('Второй вариант');

    let currentCount = 1;

    function makeCounter() {
        return function() {
            return currentCount++;
        };
    }

    let counter = makeCounter();
    let counter2 = makeCounter();

    alert( counter() );
    alert( counter() );

    alert( counter2() );
    alert( counter2() );
}


// -------------- 2 ЗАДАНИЕ -----------------------

{
    alert('Второе задание');

    function volumeParallelepiped(volume) {
            return function(b){
                return function(c){
                    return volume(2, b, c);
                }
            }
        }

    function volume(a, b, c) {
        return a * b * c;
    }

    let result = volumeParallelepiped(volume);
    alert( result(2)(2) );
}

// -------------- 3 ЗАДАНИЕ ------------------------

{
    alert('Третье задание');

    function* moveObject() {
        let x = 0, y = 0;
        let flag = true;

        while (flag) {
            let direction = prompt("Введите команду (left, right, up, down) или прервите процесс (любой символ):");

            switch (direction) {
                case 'left':
                    x -= 10;
                    break;
                case 'right':
                    x += 10;
                    break;
                case 'up':
                    y += 10;
                    break;
                case 'down':
                    y -= 10;
                    break;
                default:
                    console.log("Вы прервали процесс");
                    flag = false;
            }

            console.log(`Координаты: (${x}, ${y})`);

            yield { x, y };
        }
    }

    const generator = moveObject();
    let result = generator.next();

    while (!result.done) {
        result = generator.next();
    }
}

// -------------- 4 ЗАДАНИЕ ------------------------

{
    alert('Четвертое задание');
    
    var itemOfWindow = 10;


    itemOfWindow = 1;
    console.log(window.alert);
}
