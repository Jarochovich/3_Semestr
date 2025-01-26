const taskInput = document.getElementById("taskInput");
const addTaskBtn = document.getElementById("addTaskBtn");
const taskList = document.getElementById("taskList");


function addTask() {
    const taskName = taskInput.value.trim(); 
    if (taskName === '') {
      alert('Введите название задачи');
      return;
    }

    const taskItem = document.createElement('li');
    taskItem.className = 'task';

    const checkbox = document.createElement('input');
    checkbox.type = 'checkbox';
    checkbox.className = 'task-checkbox';

    const taskText = document.createElement('span');
    taskText.textContent = taskName;

    const actions = document.createElement('div');
    actions.className = 'actions';
  
    const deleteBtn = document.createElement('button');
    deleteBtn.textContent = 'Удалить';
    deleteBtn.className = 'delete-btn';
    deleteBtn.addEventListener('click', () => taskItem.remove());

    const editBtn = document.createElement('button');
    editBtn.textContent = 'Редактировать';
    editBtn.className = 'edit-btn';
    editBtn.addEventListener('click', () => editTask(taskItem, taskText));

    actions.appendChild(editBtn);
    actions.appendChild(deleteBtn);

    taskItem.appendChild(checkbox);
    taskItem.appendChild(taskText);
    taskItem.appendChild(actions);

    taskList.appendChild(taskItem);

    taskInput.value = '';
  }

  function editTask(taskItem, taskText) {
    const newTaskName = prompt('Измените задачу:', taskText.textContent);
    if (newTaskName !== null && newTaskName.trim() !== '') {
      taskText.textContent = newTaskName.trim();
    }
  }
  
  addTaskBtn.addEventListener('click', addTask);

  taskInput.addEventListener('keypress', (event) => {
    if (event.key === 'Enter') {
      addTask();
    }
  });

  
const filterAll = document.getElementById('filterAll');
const filterCompleted = document.getElementById('filterCompleted');
const filterActive = document.getElementById('filterActive');

// Функция для фильтрации задач
function filterTasks(filterType) {
  const tasks = taskList.querySelectorAll('.task'); // Все задачи

  tasks.forEach((task) => {
    const isChecked = task.querySelector('.task-checkbox').checked;

    // Логика фильтрации
    switch (filterType) {
      case 'all':
        task.style.display = ''; // Показываем все
        break;
      case 'completed':
        task.style.display = isChecked ? '' : 'none';
        break;
      case 'active':
        task.style.display = isChecked ? 'none' : '';
        break;
    }
  });
}

// Обработчики событий для фильтров
filterAll.addEventListener('click', () => filterTasks('all'));
filterCompleted.addEventListener('click', () => filterTasks('completed'));
filterActive.addEventListener('click', () => filterTasks('active'));
