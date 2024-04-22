
import  React from 'react';
import ProductTable from './ProductTable';

export default class FilterProductTable extends React.Component {
    render(){
        return (
            <div class="filteredData">
                
                <input type="text" placeholder="Search..." />
                <input type="checkbox" />
                <p>Only show products in stock</p>
                <ProductTable products ={this.props.products}></ProductTable>
            </div>
        );
    }
}