import { Component, OnInit } from '@angular/core'
import { HttpService } from './product.service';
import { Product } from './product';

@Component(
    {
        selector: 'products',
        templateUrl: './products.component.html',
        providers: [HttpService]
    }
)

export class ProductsComponent implements OnInit {

    products: Product[];

    constructor(private httpService: HttpService) { }

    ngOnInit() {
        this.httpService.getData().subscribe(data => this.products = data as Product[]);       

    }
}