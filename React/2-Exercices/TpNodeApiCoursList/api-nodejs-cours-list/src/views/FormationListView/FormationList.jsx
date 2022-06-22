import React, { useState } from 'react';
import AddUpdateForm from '../../components/AddUpdatteFormComponent/AddUpdateForm';
import Category from '../../components/CategoryComponent/Category';
import ObjectToArray from '../../components/ObjectToArrayComponent/ObjectToArray';
import {
    getCoursApi,
    searchCoursApi,
    postCoursApi,
    updateCoursApi,
    deleteCoursApi
} from '../../ApiService';
import './FormationList.css';

const FormationList = () => {

    /**
     * States
     */
    const [activeCategory, setActiveCategory] = useState('');
    const [activeCours, setActiveCours] = useState();
    const [formationList, setFormationList] = useState(() => FetchData());

    /**
     * Function
     */
    function FetchData() {
        getCoursApi().then((data) => {
            console.log(data);
            setFormationList(data)
        })
    }


    function AddCours(name, price, difficulty, category) {
        alert(`name : ${name} - Price : ${price} - Difficulty : ${difficulty} - Category : ${category}`);
        postCoursApi({ name, price, difficulty, category });
    }

    function UpdateCours(id,name, price, difficulty, category, created) {
        //alert(`id: ${id} - name : ${name} - Price : ${price} - Difficulty : ${difficulty} - Category : ${category} - Created : ${created}`);
        // eslint-disable-next-line no-restricted-globals
        let response = confirm(`Voulez-vous vraiment modifier le cours n°${id}`)
        if (response)
            updateCoursApi({ id, name, price, difficulty, category, created });
    }

    function DeleteCours(id) {
        // eslint-disable-next-line no-restricted-globals
        let response = confirm(`Voulez-vous vraiment supprimer le cours n°${id}`);
        if (response)
            deleteCoursApi(id).then(() => FetchData());
    }

    /**
     * Const
     */
    const categoryList = formationList ? formationList.reduce(
        (acc, elem) => acc.includes(elem.category) ? acc : acc.concat(elem.category),
        []
    ) : [];

    return (
        <div className='card main'>
            <div className="main-title">
                <h2>Api NodeJs CoursList</h2>
            </div>
            <div className="row">
                <div className="col-3">
                    <AddUpdateForm
                        categoryList={categoryList}
                        AddCours={AddCours}
                        UpdateCours={UpdateCours}
                        activeCours={activeCours}

                    />
                </div>
                <div className="col-9">
                    <Category
                        categoryList={categoryList}
                        activeCategory={activeCategory}
                        setActiveCategory={setActiveCategory}

                    />
                    <ObjectToArray
                        formationList={formationList}
                        activeCategory={activeCategory}
                        setActiveCours={setActiveCours}
                        deleteCours={DeleteCours}
                    />
                </div>
            </div>
            <div className="main-title footer">
                <span className="footerSpan">
                    Tp=&gt; Api NodeJs CoursList @2022 -
                    <a href="mailto:anthony@utopios.net">Anthony Di Persio</a> - UTOPIOS/M2i
                </span>
            </div>
        </div>
    );
};

export default FormationList;