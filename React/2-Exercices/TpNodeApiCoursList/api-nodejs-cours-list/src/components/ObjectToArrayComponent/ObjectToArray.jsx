import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faSquareArrowUpRight, faTrash } from "@fortawesome/free-solid-svg-icons";
import './ObjectToArray.css';
import CareScale from '../CareScaleComponent/CareScale';

const ObjectToArray = ({ formationList, setActiveCours, activeCategory, deleteCours}) => {
    return (
        <table className='table table-striped'>
            <thead>
                <tr>
                    <th scope='col'>Id</th>
                    <th scope='col'>Category</th>
                    <th scope='col'>Name</th>
                    <th scope='col'>Difficulty</th>
                    <th scope='col'>Price</th>
                    <th scope='col'>Created</th>
                    <th scope='col'>Updated</th>
                    <th scope='col'>Modify</th>
                    <th scope='col'>Delete</th>
                </tr>
            </thead>
            <tbody>
                {formationList?.map((cours) =>
                    !activeCategory || activeCategory === cours.category ?
                        <tr key={cours.id}>
                            <td className='bold'>{cours.id}</td>
                            <td>{cours.category}</td>
                            <td className='bold'>{cours.name}</td>
                            <td><CareScale scaleValue={cours.difficulty}/></td>
                            <td className='bold'>{cours.price}€</td>
                            <td>{cours.created}</td>
                            <td>{cours.updated}</td>
                            <td>
                                <FontAwesomeIcon
                                    icon={faSquareArrowUpRight}
                                    onClick={() => setActiveCours(cours)}
                                />
                            </td>
                            <td>
                                <FontAwesomeIcon
                                    icon={faTrash}
                                    onClick={() => deleteCours(cours.id)}
                                />
                            </td>
                        </tr>
                        : null
                )}
            </tbody>
        </table>
    )

        ;
};

export default ObjectToArray;