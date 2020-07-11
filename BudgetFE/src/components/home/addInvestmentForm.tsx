import * as React from 'react';
import { Formik } from 'formik';
import {Form, Button, Col} from 'react-bootstrap';
import axios from 'axios';
import * as Yup from 'yup';

const InvestmentSchema = Yup.object().shape({
  Amount: Yup.number()
    .min(1, 'Too Short!')
    .required('Required'),
  Type: Yup.string()
    .required('Required')
});


 
const AddInvestmentForm = () => (
  <Formik
    initialValues={{ Amount: 0, Type: '' }}
    validationSchema={InvestmentSchema}
    onSubmit={values => {
      // same shape as initial values
      console.log("Test",values);
      // Send a POST request
      axios.post("http://localhost:5200/Investment/CreateInvestment", values)
    }}
  >
    {({ handleSubmit,
        handleChange,
        values,
        touched,
        errors, }) => (
      <Form onSubmit={handleSubmit}>
        <Form.Row>
          <Form.Group as={Col} controlId="formGridEmail">
            <Form.Label>Amount ($)</Form.Label>
            <Form.Control name="Amount" type="number" placeholder="Enter Amount" value={values.Amount} onChange={handleChange}/>
          </Form.Group>

          <Form.Group as={Col} controlId="formGridPassword">
            <Form.Label>Investment Type</Form.Label>
            <Form.Control name="Type" as="select" value={values.Type} onChange={handleChange}>
              <option>Choose...</option>
              <option>VOO</option>
              <option>VOOV</option>
            </Form.Control>
          </Form.Group>
          <div className="btn-inv">
            <Button variant="primary" type="submit">
              +
              </Button>
          </div>

        </Form.Row>
      </Form>
    )}
  </Formik>
);
 
 export default AddInvestmentForm;