[Point](../../Point.md) > [Status](../Status.md) > [Fault_Status](.)
# Fault_Status

**Display name:** Fault Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fault_Status;1

---


## Child interfaces
* [Humidifier_Fault_Status](Humidifier_Fault_Status.md)
* [Last_Fault_Code_Status](Last_Fault_Code_Status.md)

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
