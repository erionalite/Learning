
import  React from 'react';
import { useState } from 'react';
import ProductTable from './ProductTable';

export default function FilterProductTable(props) {
    const [filteredText,setFilteredText] = useState(' ');
    const [inStockOnly,setInStockOnly] = useState(false);
        
    return (
        <div class="filteredData">
            
            <input type="text" value={filteredText} placeholder="Search..." />
            <input type="checkbox" checked={inStockOnly}/>
            <p>Only show products in stock</p>
            <ProductTable products ={props.products}></ProductTable>
        </div>
    );
}
