import logo from './logo.svg';
import FilterProductTable from './components/FilterProductTable';
import Data from './data.js';
import './App.css';
import ProductTable from './components/ProductTable';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        Product Data
      </header>
       {FilterProductTable(Data.getProducts())}
    </div>
  );
}

export default App;
