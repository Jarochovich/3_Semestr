//-------------- 1 ЗАДАНИЕ ----------------------
{
    console.log("1 ЗАДАНИЕ");

    let person = {
        name: 'John',
        years: 22,

        greet: function() {
            console.log(`Привет, ${this.name}!`);
        },

        ageAfterYears() {
            console.log(`Текущий возраст: ` + this.years);
        },
    }

    person.greet();
    person.ageAfterYears();
    
}
//-------------- 2 ЗАДАНИЕ ----------------------
{
    console.log("2 ЗАДАНИЕ");

    let car = {
        model: 'BMW M5 520',
        year: 2020,

        getInfo: function () {
            console.log(`Машина ${this.model} имеет ${this.year} год выпуска`);  
        }
    }

    car.getInfo();
    
}
//-------------- 3 ЗАДАНИЕ ----------------------
{
    console.log("3 ЗАДАНИЕ");

    function Book(title, author) {
        this.title = title;
        this.author = author;
    }

    let book1 = new Book('Лев Толстой', 'Война и мир');
    console.log(book1);

    let book2 = new Book('Александр Пушкин', 'Евгений Онегин');
    console.log(book2);

    let book3 = new Book('Федор Достоевский', 'Преступление и наказание');
    console.log(book3);

}
//-------------- 4 ЗАДАНИЕ ----------------------
{
    console.log("4 ЗАДАНИЕ");

    let team = {
        players: ['Андрюха', 'Темыч', 'Стасян', 'Егорчик', 'Леха', 'Декстер'],
        
        getInfoPlayers: function () {
            this.players.forEach(player => console.log(player));
        }
    }

    team.getInfoPlayers();
}
//-------------- 5 ЗАДАНИЕ ----------------------
{
    console.log("5 ЗАДАНИЕ");

    const counter = (function() {
        let count = 0;

        return {
            increment: function () {
                return ++this.count;
            },
            decrement: function () {
                return --count;
            },
            getCount: function() {
               return count;
            }
        }

    }) ();


    console.log(counter.increment());
    console.log(counter.increment());
    console.log(counter.decrement());
    console.log(counter.getCount());

}
//-------------- 6 ЗАДАНИЕ ----------------------
{
    console.log("6 ЗАДАНИЕ");

    let item = {
        price: 1500
    };

   Object.defineProperty(item, 'price', {
        writable: true,
        enumerable: false,
        configurable: true,
    });

    let descriptor = Object.getOwnPropertyDescriptor(item, 'price');
    console.log(JSON.stringify(descriptor, null, 2));

    Object.defineProperty(item, 'price', {
        writable: false,
        enumerable: true,
        configurable: true
    });

    descriptor = Object.getOwnPropertyDescriptor(item, 'price');
    console.log(JSON.stringify(descriptor, null, 2));
    
}
//-------------- 7 ЗАДАНИЕ ----------------------
{
    console.log("7 ЗАДАНИЕ");

    let circle = {
        radius: 2,

        get getSquareCircle() {
            return Math.pow(this.radius, 2) * Math.PI;
        },

        set RaduisCircle(value) {
            this.radius = value;
        },

        get RaduisCircle() {
            return this.radius;
        }
    };

    console.log(circle.getSquareCircle);
    console.log(circle.RaduisCircle);

    circle.RaduisCircle = 10;

    console.log(circle.getSquareCircle);

}
//-------------- 8 ЗАДАНИЕ ----------------------
{
    console.log("8 ЗАДАНИЕ");

    let car = {
        make: 'BMW',
        model: 'M5',
        year: 2023,
    };

    // Object.defineProperty(car, 'make', {
    //     configurable: false
    // });

    // Object.defineProperty(car, 'model', {
    //     configurable: false
    // });

    // Object.defineProperty(car, 'year', {
    //     configurable: false
    // });

    Object.defineProperties(car, {
        make: {configurable: false},
        model: {configurable: false},
        year: {configurable: false}
    })

    let descriptor = Object.getOwnPropertyDescriptors(car, 'make', 'model', 'year');

    console.log( JSON.stringify(descriptor, null, 2) );

}
//-------------- 9 ЗАДАНИЕ ----------------------
{
    console.log("9 ЗАДАНИЕ");

    let array = [5,2,3];

    Object.defineProperty(array, 'sum', {
        get() {
            return array.reduce((accum, item) => accum+=item) 
        },
        
        
    });

    console.log(array.sum);

    let descriptor = Object.getOwnPropertyDescriptor(array, 'sum');
    console.log(JSON.stringify(descriptor, null, 2));
    
}
//-------------- 10 ЗАДАНИЕ ----------------------
{
    console.log("10 ЗАДАНИЕ");

    let rectangle = {
        width: 1,
        height: 1,

        get SquareRect() {
            return this.width * this.height;
        },

        get WidthRect() {
            return this.width;
        },
        set WidthRect(value) {
            this.width = value;
        },

        get HeightRect() {
            return this.height;
        },
        set HeightRect(value) {
            this.height = value;
        }
    };

    rectangle.WidthRect = 5;
    rectangle.HeightRect = 10;

    console.log(rectangle.SquareRect);
    
}
//-------------- 11 ЗАДАНИЕ ----------------------
{
    console.log("11 ЗАДАНИЕ");

    let user = {
        firstName: 'John',
        lastName: 'Smit',

        get FullName() {
            return `${this.firstName} ${this.lastName}`;
        },

        set FullName(value) {
            [this.firstName, this.lastName] = value.split(" ");
        }
    };

    console.log(user.FullName);
    user.FullName = 'Andrey Kasper';
    console.log(user.FullName);
    
}