const __BASE_URL = 'http://localhost:7777/api';

// Get
export const getCoursApi = async () => {
    const response = await fetch(__BASE_URL+'/cours')
    .then((res)=> 
        res.json()
    );
    //console.log(response);
    return response.data;
}

// Get/id
export const searchCoursApi = async (id) => {
    const response = await fetch(__BASE_URL+'/cours/'+id)
    .then((res)=> 
        res.json()
    );
    console.log(response);
    return response.data;
}
