import React, { useState } from 'react';
import './AddUpdateForm.css';

const AddUpdateForm = ({ activeCours, categoryList, AddCours, UpdateCours }) => {

    const [name, setName] = useState(activeCours ? activeCours.Name : "");
    const [price, setPrice] = useState(activeCours ? activeCours.Price : 0);
    const [difficulty, setDifficulty] = useState(activeCours ? activeCours.Difficulty : "0");
    const [category, setCategory] = useState(activeCours ? activeCours.Category : "---");

    return (
        <form className='form-control'>
            {
                activeCours !== undefined ?
                    <h2 className='form-title'>Modifier le cours n°{activeCours.id}</h2>
                    :
                    <h2 className='form-title'>Ajouter un cours</h2>
            }
            <div className="mb-3">
                <label htmlFor="name">Name :</label>
                <input type="text" name='name' className='form-control' onChange={(e) => setName(e.target.value)} defaultValue={activeCours?.name} />
            </div>
            <div className="mb-3">
                <label htmlFor="price">Price :</label>
                <input type="text" name='price' className='form-control' onChange={(e) => setPrice(e.target.value)} defaultValue={activeCours?.price} />
            </div>
            <div className="mb-3">
                <label htmlFor="difficulty">Difficulté :</label>
                <select
                    name="difficulty"
                    className='col form-select difficulte'
                    onChange={(e) => setDifficulty(e.target.value)}
                    defaultValue={activeCours?.difficulty}
                >
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>

                </select>
            </div>
            <div className="row mb-3">
                <label htmlFor="category">Catégory :</label>
                <select
                    name="category"
                    className='col form-select categories'
                    onChange={(e) => setCategory(e.target.value)}
                    defaultValue={activeCours?.category}
                >
                    <option value="---">---</option>
                    {
                        categoryList?.map(
                            (cat, index) => (
                                <option key={index} value={cat}>{cat}</option>
                            )
                        )
                    }
                </select>
            </div>
            {
                activeCours !== undefined ?
                    <button
                        type='submit'
                        className='btn btn-secondary form-control formBtn'
                        id='Update'
                        onClick={
                            () => UpdateCours(
                                activeCours.id,
                                name ? name : activeCours.name,
                                price ? price : activeCours.price,
                                difficulty !== "0" ? difficulty : activeCours.difficulty,
                                category != "---" ? category : activeCours.category,
                                activeCours.created
                            )
                        }
                    >
                        Modifier
                    </button>
                    :
                    <button
                        type='submit'
                        className='btn btn-secondary form-control formBtn'
                        id='Update'
                        onClick={
                            () => AddCours(
                                name,
                                price,
                                difficulty,
                                category
                            )
                        }
                    >
                        Ajouter
                    </button>
            }


        </form>
    );
};

export default AddUpdateForm;