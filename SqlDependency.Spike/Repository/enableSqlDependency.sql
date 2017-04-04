alter database [RaceSpike] set enable_broker  with rollback immediate;
alter authorization on database::[racespike] to [sa];