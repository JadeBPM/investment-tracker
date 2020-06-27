import * as React from 'react';
import axios from 'axios';
import {useState} from 'react';
import {Form, Button, Col} from 'react-bootstrap';
import './style.css';

function Home() {

  const submitInvestment = () => {
    console.log("F")
    axios.post('http://localhost:5200/Investment/CreateInvestment', { Amount: 100, type: "voo"})
      .then((response: any) => {
        console.log("post finished")
      })
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
            <Button variant="primary" type="submit" onClick={submitInvestment}>
              +
            </Button>
          </div>
          
        </Form.Row>
      </Form>
    </div>
  );
};

export default Home;
