import { TestBed } from '@angular/core/testing';

import { CrearlibroService } from './crearlibro.service';

describe('CrearlibroService', () => {
  let service: CrearlibroService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CrearlibroService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
