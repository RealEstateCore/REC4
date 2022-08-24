[Point](../../../../../Point.md) > [Status](../../../../Status.md) > [On_Status](../../../On_Status.md) > [On_Off_Status](../../On_Off_Status.md) > [Start_Stop_Status](../Start_Stop_Status.md) > [Run_Status](#)
# Run_Status

**Display name:** Run Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Run_Status;1

---


## Child interfaces
* [Run_Request_Status](Run_Request_Status.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
