//---------------- 1 ЗАДАНИЕ ---------------------------
{
    console.log('1 ЗАДАНИЕ');
    
    let numbers = [1,2,3,4,5,6,7,8,9];
    let [one, two] = numbers;

    console.log(one);
    console.log(two);
}

//---------------- 2 ЗАДАНИЕ ----------------------------
{
    console.log('2 ЗАДАНИЕ');
    
    let user = {
        name: 'John',
        age: 22,
    };

    let admin = {
        isAdmin: true,
        user: {...user},
    }

    console.log(admin);
}

//----------------- 3 ЗАДАНИЕ ----------------------------
{
    console.log('3 ЗАДАНИЕ');
    
    let store = {
        state: {
            profilePage: {
                  posts: [
                    {id: 1, message: 'Hi', likesCount: 12},
                    {id: 2, message: 'By', likesCount: 1},
                ],
                newPostText: 'About me',
            },
            dialogPage: {
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
    }

    const profilePage = {
        posts: [
          {id: 1, message: 'Hi', likesCount: 12},
          {id: 2, message: 'By', likesCount: 1},
      ],
      newPostText: 'About me',
  };

    let {
        posts: [
            item1,
            item2
        ],
        newPostText
    } = profilePage;

    console.log(item1.message);
    

    // let {
    //     state: {
    //         profilePage: {
    //             posts,
    //             newPostText,
    //         },
    //         dialogPage: {
    //             dialogs,
    //             messages,
    //         },
    //         sidebar,
    //     },
    // } = store;

    // posts.forEach(post => console.log(post.likesCount))

    // let idDevisionByTwo = dialogs.filter(dialog => dialog.id % 2 == 0);
    // console.log(idDevisionByTwo);

    // let replacingMessages = messages.map(message => message.message = 'Hello user');
    // console.log(replacingMessages);
}

//---------------- 4 ЗАДАНИЕ ---------------------------------
{
    console.log('4 ЗАДАНИЕ');
    
    let tasks = [
        {id: 1, title: 'HTML&CSS', isDone: true},
        {id: 2, title: 'JS', isDone: true},
        {id: 3, title: 'ReactJS', isDone: false},
        {id: 4, title: 'Rest API', isDone: false},
        {id: 5, title: 'GraphQL', isDone: false},
    ];

   let task = [ 
   {id: 6, title: 'TypeScript', isDone: true}
    ];
    

   tasks = [task, ...tasks];
   console.log(tasks);
}

//---------------- 5 ЗАДАНИЕ ----------------------------------
{
    console.log('5 ЗАДАНИЕ');
    
    function sumValues(x, y, z) {
        return x + y + z;
    }

    const arr = [1, 2, 3]

    console.log( sumValues(...arr) );
}
