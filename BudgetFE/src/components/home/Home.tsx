import * as React from 'react';
import axios from 'axios';
import {useState, useEffect} from 'react';
import { ListGroup } from 'react-bootstrap';
import { Investment } from './model';
import AddInvestmentForm from './addInvestmentForm';
import './style.css';

function Home() {

  const [investments, setInvestments] = useState<Investment[]>();

  useEffect(() => {

    axios.get('http://localhost:5200/Investment/GetInvestments')
    .then((response: { data: Investment[]}) => {
      console.log(response)
      setInvestments(response.data);
    })
  },[]);

  function displayInvestments() {

    return(
      <ListGroup>
        {
          investments?.map(x => {
            return(
              <div>
                <ListGroup.Item>{x.type} {x.current} {x.initial}</ListGroup.Item>
            </div>
          )})
        }
      </ListGroup>
    );
  }

  return (
    <div className="container my-2">
     {AddInvestmentForm()}
      {displayInvestments()}
    </div>
  );
};

export default Home;
