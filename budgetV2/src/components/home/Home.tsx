import * as React from 'react';
import axios from 'axios';
import {useState} from 'react';
import {Form, Button, Col} from 'react-bootstrap';
import './style.css';

const Home = () => {
  const [apiResult, setApiResult] = useState('');
  const callApi = () => {
    // quick and dirty test for calling the api
    axios
      .get('http://localhost:5200/Login/GetLogin')
      .then((response: any) => {
        console.log(response);
        setApiResult(JSON.stringify(response.data, null, 2));
      })
      .catch((error) => {
        const {status, statusText} = error.response;
        setApiResult(`${status}: ${statusText}`);
      });
    console.log(apiResult);
  };

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
              <option>...</option>
            </Form.Control>
          </Form.Group>
          <div className="btn-inv">
            <Button variant="primary" type="submit" onClick={callApi}>
              +
            </Button>
          </div>
          
        </Form.Row>
      </Form>
    </div>
  );
};

export default Home;
