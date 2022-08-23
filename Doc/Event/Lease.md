# Lease
**DTMI:** dtmi:org:w3id:rec:Lease;1
## Display name
- **en:** Lease
## Description
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|leaseOf|**en**: lease of|**en**: The object (e.g., property, equipment, etc) that this a lease of.|0-Infinity|||True|
|leasee|**en**: leasee|**en**: The agent leasing some leasable object, i.e., the user of the asset.|0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|leasor|**en**: leasor|**en**: The agent leasing out some leasable object, i.e., the owner of the asset.|0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|regulatedBy|**en**: regulated by|**en**: Indicates the contract regulating the terms of the lease in question. |0-Infinity|dtmi:org:w3id:rec:LeaseContract;1||True|
## Properties
### Inherited Properties
* **dtmi:org:w3id:rec:Event;1:** customTags, end, externalIds, name, start, timestamp
## Target Of
* LeaseContract.regulates
