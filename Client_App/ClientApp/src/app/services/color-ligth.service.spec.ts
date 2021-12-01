import { TestBed } from '@angular/core/testing';

import { ColorLigthService } from './color-ligth.service';

describe('ColorLigthService', () => {
  let service: ColorLigthService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ColorLigthService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
