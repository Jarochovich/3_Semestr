class Task {
    constructor(id, name = 'задача', state = false) {
        this.id = id,
        this.name = name,
        this.state = state,

        this.state == true ? this.state = 'задача выполнена' : this.state = 'задача не выполнена'
    }

    changeName() {
        let changeN = prompt(`Введите измененное название задачи "${this.name}" на: `, '');
        this.name = changeN;
    }

    changeStatus() {
        let changeS = prompt(`Введите, на какое состояние вы хотите изменить задачу "${this.name}": `, 'задача выполнена');
        changeS = changeS.toLowerCase().trim();
        this.state = changeS;
    }
}

class Todolist {
    constructor(id, name) {
        this.id = id,
        this.name = name,
        this.tasks = []
    }

    changeNameList() {
        let changeN = prompt("Введите измененное название Todolist'a: ", '');
        this.name = changeN;
    }

    addTask(newTask)
    {
        let result = this.tasks.find((task) => task == newTask);

        if(!result) {
            this.tasks.push(newTask);
        }
    }

    filteredByStateTasks() {
        console.log('Фильтрация задач по состоянию:');

        console.log('Выполненные задачи:');
        let succes = this.tasks.filter( task => task.state == 'задача выполнена');
        console.log(succes);

        console.log('Не выполненные задачи:');
        let notSucces = this.tasks.filter( task => task.state == 'задача не выполнена');
        console.log(notSucces);
    }

    printAllTasks() {
        console.log(`Все задачи ${this.name}`);
        console.log(this.tasks);
    }
}

let task1 = new Task(1, 'Сдать лабу 10 JS', true);
let task2 = new Task(2, 'Сдать весь JS', false);
let task3 = new Task(3, 'Продать подик Сани Косемука', false);
let task4 = new Task(4, 'Сдать лабы по C#', true);
let task5 = new Task(5, 'Сходить в "Соседи"', true);
let task6 = new Task(6, 'Сдать эту лабу JS', true);
let task7 = new Task(7, 'Переселиться в 5', false);


let todolist1 = new Todolist(1, 'todolist_1');
let todolist2 = new Todolist(2, 'todolist_2'); 

task3.changeStatus();

todolist1.addTask(task1);
todolist1.addTask(task2);
todolist1.addTask(task3);

todolist1.filteredByStateTasks();
todolist1.printAllTasks();

todolist2.addTask(task4);
todolist2.addTask(task5);
todolist2.addTask(task5);
todolist2.addTask(task6);
todolist2.addTask(task7);

todolist2.filteredByStateTasks();
todolist2.printAllTasks();
