import React from "react";
import ProductCategoryRow  from './ProductCategoryRow';
import ProductRow from './ProductRow'


export default class ProductTable extends React.Component {

    getUniqueCategories = (products) =>{
        let categories = this.props.products.map(product =>{ return product.category;});
        let visited = []
        categories.map((category)=>{
            if(visited.indexOf(category) == -1)
                visited.push(category);
        })
        return visited;
    };
    
    getProductByCategory = (category,products) =>{
        return products.filter(product => product.category == category);
    };

    render(){
        
        let products = this.props.products;

        return <div>
           
            <div class="product-data-results">
            <div class="product-data-header">
                <div class="product-name"> Name </div>
                <div class="product-price"> Price </div>
            </div>
            {
                this.getUniqueCategories(products).map( category => {

                  return <div>
                        <ProductCategoryRow value={category}></ProductCategoryRow>
                        {
                            this.getProductByCategory(category,products).map( product => {
                                 return <ProductRow product={product}></ProductRow>
                            })
                        }
                     </div>;

                })
            }
            </div>
            </div> 

    }
}