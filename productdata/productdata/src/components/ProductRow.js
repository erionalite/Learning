import  React from 'react';

export default class ProductRow extends React.Component{

    render(){

        return <div class="product-row">
                <div class="product-name">{this.props.product.name}</div>
                <div class="product-price">{this.props.product.price}</div>
            </div>
    }
}
