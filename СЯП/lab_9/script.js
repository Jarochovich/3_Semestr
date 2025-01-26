{
    // ------------------------- 1 ЗАДАНИЕ --------------------------
    console.log('Задание 1');

    // Квадраты
    const square = {
        length: 10,
        color: 'yellow',
    };
    const smallSquare = {
        __proto__: square,
        length: 5,
    };

    // Круги
    const circle = {
        radius: 5,
        color: 'white',
    };
    const greenCircle = {
        __proto__: circle,
        color: 'green',
    };

    // Треугольники
    const triangle = {
        length: 5,
        color: 'white',
        countLine: 1,
    };
    const threeLineTriangle = {
        __proto__: triangle,
        countLine: 3,
    };

    // Вывод собственных свойств
    console.log(Object.getOwnPropertyDescriptors(smallSquare));
    console.log(Object.getOwnPropertyDescriptors(greenCircle));
    console.log(Object.getOwnPropertyDescriptors(threeLineTriangle));
}
{
    //-------------------- 2 ЗАДАНИЕ --------------------------------

    console.log('Задание 2');

    class Human {
        constructor(firstName, lastName, yearOfBirth, address) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.address = address;
        }

        set age(value) {
            this.yearOfBirth = new Date().getFullYear() - value;
        }

        get age() {
            return new Date().getFullYear() - this.yearOfBirth;
        }

        setAddress(newAddress) {
            this.address = newAddress;
        }
    }

    class Student extends Human {
        constructor(firstName, lastName, yearOfBirth, address, faculty, course, group, recordBookNumber) {
            super(firstName, lastName, yearOfBirth, address);
            this.faculty = faculty;
            this.course = course;
            this.group = group;
            this.recordBookNumber = recordBookNumber;
        }

        setCourse(newCourse) {
            this.course = newCourse;
        }

        setGroup(newGroup) {
            this.group = newGroup;
        }

        getFullName() {
            return `${this.firstName} ${this.lastName}`;
        }
    }

    class Faculty {
        constructor(name, groupCount, studentCount) {
            this.name = name;
            this.groupCount = groupCount;
            this.studentCount = studentCount;
        }

        setGroupCount(newCount) {
            this.groupCount = newCount;
        }

        setStudentCount(newCount) {
            this.studentCount = newCount;
        }

        getDev(students) {
            return students.filter(student => student.recordBookNumber[0] === '3').length;
        }

        getGroup(students, group) {
            return students.filter(student => student.group === group);
        }
    }

    const student1 = new Student('Случайный', 'Студент', 2005, 'Minsk', 'FIT', 3, '1', '73201300');
    const student2 = new Student('Ярохович', 'Станислав', 2005, 'Minsk', 'FIT', 2, '1', '71231029');

    const faculty = new Faculty('ФИТ', 10, 150);
    const students = [student1, student2];

    console.log(student1.getFullName());
    console.log(faculty.getDev(students));
    console.log(faculty.getGroup(students, '1'));

    console.log(student1);
}
