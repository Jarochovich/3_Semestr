// ОБЪЕКТ USER
{
    console.log('1 ЗАДАНИЕ');
    
    let user = {
        name: 'Masha',
        age: 21,
    };

    let copyUser = {...user};
    console.log(copyUser);
    
}
// МАССИВ NUMBERS
{
    console.log('2 ЗАДАНИЕ');

    let numbers = [1,2,3];

    let copyNumbers = [...numbers];
    console.log(copyNumbers);

}
// ОБЪЕКТ USER1
{
    console.log('3 ЗАДАНИЕ');

    let user1 = {
        name: 'Masha',
        age: 23,
        location: {
            city: 'Minsk',
            country: 'Belarus',
        }
    };

    let copyUser1 = {
        ...user1,
         location: {...user1.location}
    };

    console.log('Оригинал:');
    console.log(user1);
    
    console.log('Измененная копия:');
    console.log(copyUser1);
    
}
// ОБЪЕКТ USER2
{
    console.log('4 ЗАДАНИЕ');

    let user2 = {
        name: 'Masha',
        age: 28,
        skills: ['HTML', 'CSS', 'JavaScript', 'React']
    };

    let copyUser2 = {
        ...user2,
        skills: user2.skills.map(skill => ({...skill}))};
    
    console.log('Оригинал:');
    console.log(user2);
    
    console.log('Измененная копия:');
    console.log(copyUser2);

}
// МАССИВ ARRAY
{
    console.log('5 ЗАДАНИЕ');

    const array = [
        {id: 1, name: 'Vasya', group: 10}, 
        {id: 2, name: 'Ivan', group: 11},
        {id: 3, name: 'Masha', group: 12},
        {id: 4, name: 'Petya', group: 10},
        {id: 5, name: 'Kira', group: 11},
    ];

    let copyArray = [...array.map(item => ({...item}))];

    console.log("Оригинал:");
    console.log(array);
    
    console.log("Измененная копия:");
    console.log(copyArray);
    
}
// ОБЪЕКТ USER4
{
    console.log('6 ЗАДАНИЕ');

    let user4 = {
        name: 'Masha',
        age: 19,
        studies: {
            university: 'BSTU',
            speciality: 'designer',
            year: 2020,
            exams: {
                maths: true,
                programming: false
            }
        }
    };

    let copyUser4 = {
        ...user4,
        studies: {
            ...user4.studies,
            exams: {...user4.studies.exams}
        }
    };

    copyUser4.studies.year = 2024;

    console.log("Оригинал:");
    console.log(user4);
    
    console.log("Измененная копия:");
    console.log(copyUser4);
    
}
// ОБЪЕКТ USER5
{
    console.log('7 ЗАДАНИЕ');

    let user5 = {
        name: 'Masha',
        age: 22,
        studies: {
            university: 'BSTU',
            speciality: 'designer',
            year: 2020,
            department: {
                faculty: 'FIT',
                group: 10,
            },
            exams: [
                { maths: true, mark: 8 },
                { programming: true, mark: 4 },
            ]
        }
    };
    
    let copyUser5 = {
        ...user5,
        studies: {
            ...user5.studies,
            department: { ...user5.studies.department },
            exams: user5.studies.exams.map(exam => ({ ...exam }))
        }
    };
    
    copyUser5.studies.department.group = 12;
    copyUser5.studies.exams[1].mark = 10;
    
    console.log("Оригинал:");
    console.log(user5);

    console.log('Измененная копия:');
    console.log(copyUser5);

}
// ОБЪЕКТ USER6
{
    console.log('8 ЗАДАНИЕ');

    let user6 = {
        name: 'Masha',
        age: 21,
        studies: {
            university: 'BSTU',
            speciality: 'designer',
            year: 2020,
            department: {
                faculty: 'FIT',
                group: 10,
                        },
            exams: [
                        { 
                maths: true,
                mark: 8,
                professor: {
                    name: 'Ivan Ivanov ',
                    degree: 'PhD'
                           }
                        },
                        { 
                programming: true,
                mark: 10,
                professor: {
                    name: 'Petr Petrov',
                    degree: 'PhD'
                           }
                        },
                ]   
                }
    };

    let copyUser6 = {
        ...user6,
        studies: {
            ...user6.studies,
            department: {...user6.studies.department},
            exams: user6.studies.exams.map(exam => 
                ({...exam,
                    professor: {...exam.professor}
                }))
        }
    };

    // copyUser6.studies.exams[1].professor.name = 'Andrey Lavanda';
    copyUser6.studies.exams[0].mark = 10;

    console.log("Оригинал:");
    console.log(user6);
    
    console.log("Измененная копия:");
    console.log(copyUser6);
}
// ОБЪЕКТ USER7
{
    console.log('9 ЗАДАНИЕ');

    let user7 = {
        name: 'Masha',
        age: 20,
        studies: {
            university: 'BSTU',
            speciality: 'designer',
            year: 2020,
            department: {
                faculty: 'FIT',
                group: 10,
            },
            exams: [
                { 
            maths: true,
            mark: 8,
            professor: {
                name: 'Ivan Petrov',
                degree: 'PhD',
                articles: [
                            {title: "About HTML", pagesNumber: 3},
                            {title: "About CSS", pagesNumber: 5},
                            {title: "About JavaScript", pagesNumber: 1},
                        ]
            }
             },
                { 
            programming: true,
            mark: 10,
            professor: {
                name: 'Petr Ivanov',
                degree: 'PhD',
                articles: [
                            {title: "About HTML", pagesNumber: 3},
                            {title: "About CSS", pagesNumber: 5},
                            {title: "About JavaScript", pagesNumber: 1},
                          ]
            }
             },
            ]
        }
    };

    let copyUser7 = {
        ...user7,
        studies: {
            ...user7.studies,
            department: 
                {...user7.studies.department},
            exams: user7.studies.exams.map(exam => 
                ({...exam,
                    professor: 
                    {...exam.professor,
                     articles: exam.professor.articles.map(atricle => ({...atricle}))
                    }

                }))
        }
    };

    copyUser7.studies.exams[1].professor.articles[1].pagesNumber = 3;

    console.log("Оригинал:");
    console.log(user7);
    
    console.log("Измененная копия:");
    console.log(copyUser7);
    
}
// ОБЪЕКТ STORE
{
    console.log('10 ЗАДАНИЕ');

    let store = {
        state: {    // 1 уровень
            profilePage: {  // 2 уровень
                posts: [    // 3 уровень
                    {id: 1, message: 'Hi', likesCount: 12},
                    {id: 2, message: 'By', likesCount: 1},
                ],
                newPostText: 'About me',
            },
            dialogsPage: {
                dialogs: [
                    {id: 1, name: 'Valera'},
                    {id: 2, name: 'Andrey'},
                    {id: 3, name: 'Sasha'},
                    {id: 4, name: 'Victor'},
                ],
                messages: [
                    {id: 1, message: 'hi'},
                    {id: 2, message: 'hi hi'},
                    {id: 3, message: 'hi hi hi'},
                ],
            },
            sidebar: [],
        },
    };

    store.state.profilePage.posts[0].likesCount = 10;

    let copyStore = {
        ...store,
        state: {
            ...store.state,
            profilePage: {
                ...store.state.profilePage,
                posts: store.state.profilePage.posts.map(post => ({...post}))
            },
            dialogsPage: {
                ...store.state.dialogsPage,
                dialogs: store.state.dialogsPage.dialogs.map(dialog => ({...dialog})),
                messages: store.state.dialogsPage.messages.map(message => ({...message}))
            },
            sidebar: [...store.state.sidebar]
            },
    };     
        

    copyStore.state.dialogsPage.messages.map(item => item.message = "Hello");
    copyStore.state.profilePage.posts.map(item => item.message = "Hello");
    
    console.log("Оригинал:");
    console.log(store);
    
    console.log("Измененная копия:");
    console.log(copyStore);
}