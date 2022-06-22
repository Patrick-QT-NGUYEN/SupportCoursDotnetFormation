import React from 'react';
import './Category.css';

const Category = ({categoryList , setActiveCategory, activeCategory}) => {
    //console.log(categoryList);
    return (
        <div className='category'>
            <select 
                name="category" 
                className='form-select categories'
                value = {activeCategory}
                onChange={(e)=> setActiveCategory(e.target.value)}
            >
                    <option value ="">---</option>
                    {
                        categoryList.map(
                            (cat)=>(
                                <option key={cat} value={cat} >{cat}</option>
                            )
                        )
                    }
            </select> 

            <button
                className='btn btn-secondary'
                onClick={()=> setActiveCategory('')} 
            >Reset
            </button>          
        </div>
    );
};

export default Category;