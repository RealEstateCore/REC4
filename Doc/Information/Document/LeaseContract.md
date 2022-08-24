[Information](../Information.md) > [Document](Document.md) > [LeaseContract](#)
# LeaseContract

Formal document that identifies the Tenant and the leased asset or property; states lease term and fee (rent), and detailed terms and conditions of the lease agreement.


**Display name:** Lease contract<br />
**DTMI:** dtmi:org:w3id:rec:LeaseContract;1

---
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|regulates|**en**: regulates|**en**: Indicates the lease(s) that this contract regulates the conditions of.|0-Infinity|dtmi:org:w3id:rec:Lease;1||True|
### Inherited Relationships
* **dtmi:org:w3id:rec:Document;1:** documentTopic, url
## Properties
### Inherited Properties
* **dtmi:org:w3id:rec:Information;1:** customTags, externalIds, name
## Target Of
### Direct
* Lease.regulatedBy
### Inherited
* Asset.documentation
* BuildingElement.documentation
* Collection.documentation
* Architecture.documentation
