import { TestBed } from '@angular/core/testing';

import { DATAService } from './data.service';

describe('DATAService', () => {
  let service: DATAService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DATAService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
