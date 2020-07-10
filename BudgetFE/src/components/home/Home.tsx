import * as React from 'react';
import axios from 'axios';
import {useState, useEffect} from 'react';
import {Form, Button, Col} from 'react-bootstrap';
import { Investment } from './model';
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


  function submitInvestment() {
   console.log(investments)
  }

  function displayInvestments() {

    return(
      <div>
        {
          investments?.map(x => {
            return(<div>
              {x.type}
            </div>)
          })
        }
      </div>
    );
  }

  return (
    <div className="container my-2">
      <Form>
        <Form.Row>
          <Form.Group as={Col} controlId="formGridEmail">
            <Form.Label>Amount ($)</Form.Label>
            <Form.Control type="number" placeholder="Enter Amount" />
          </Form.Group>

          <Form.Group as={Col} controlId="formGridPassword">
            <Form.Label>Investment Type</Form.Label>
            <Form.Control as="select" value="Choose...">
              <option>Choose...</option>
              <option>VOO</option>
              <option>VOOV</option>
            </Form.Control>
          </Form.Group>
          <div className="btn-inv">
            <Button variant="primary" type="submit" onClick={() => submitInvestment}>
              +
            </Button>
          </div>
          
        </Form.Row>
      </Form>
      {displayInvestments()}
    </div>
  );
};

export default Home;
