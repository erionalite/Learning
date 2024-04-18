
import  React from 'react';

export default class FilterProductTable extends React.Component {
    render(){
        return (
            <div>
                <input type="text" placeholder="Search..." />
                <input type="checkbox" />
                <p>Only show products in stock</p>
            </div>
        );
    }
}