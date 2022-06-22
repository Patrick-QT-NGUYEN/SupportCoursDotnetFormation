const __BASE_URL = 'http://10.125.51.66:7777/api';
const __HEADERS = {
    'Accept': 'application/json',
    'Content-Type': 'application/json'
}

export const getCoursApi = async () => {
    const response = await fetch(__BASE_URL + "/cours")
        .then((res) =>
            res.json()
        )
    return response.data
}

export const searchCoursApi = async (coursId) => {
    const response = await fetch(__BASE_URL + '/cours' + coursId)
        .then((res) =>
            res.json()
        );
    return response.data;
}

export const postCoursApi = (async (cours) => {
    alert(`Name : ${cours.name} - Price : ${cours.price}€ - Difficulty : ${cours.difficulty}/5 - Categry : ${cours.category} `);
    const rawResponse = await fetch(__BASE_URL + '/cours', {
        method: 'POST',
        headers: __HEADERS,
        body: JSON.stringify({
            name: cours.name,
            price: cours.price,
            difficulty: cours.difficulty,
            category: cours.category
        })
    })
    const Content = await rawResponse.json();
    console.log("POST Response : " + Content);
    return Content;
});

export const updateCoursApi = (async (cours) => {
    const rawResponse = await fetch(__BASE_URL + '/cours/' + cours.id, {
        method: 'PUT',
        headers: __HEADERS,
        body: JSON.stringify({
            name: cours.name,
            price: cours.price,
            difficulty: cours.difficulty,
            category: cours.category,
            created: new Date(cours.created)
        })
    })
    const Content = await rawResponse.json();
    console.log("UPDATE Response : " + Content);
    return Content;
})

export const deleteCoursApi = (async (coursId) => {
    const rawResponse = await fetch(__BASE_URL + '/cours/' + coursId, {
        method: 'DELETE',
        headers: __HEADERS
    });
    const Content = await rawResponse.json();
    console.log("DELETE Response : " + Content);
    return Content;
});
