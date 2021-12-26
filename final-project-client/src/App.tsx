import './App.css';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import { Login } from './components/login';
import { Switch } from 'react-router-dom';
import { createBrowserHistory } from 'history';
import Register from './components/register';
import { Welcome } from './components/welcome';

const history = createBrowserHistory({})
function App() {
  return (
    <div className="App">
      <Router >
        <Switch >

          <Route exact path="/" component={Welcome} />
          <Route path="/Register" component={Register} />
          <Route path="/Login" component={Login}/>
        </Switch>
      </Router>
    </div>
  );
}

export default App;
