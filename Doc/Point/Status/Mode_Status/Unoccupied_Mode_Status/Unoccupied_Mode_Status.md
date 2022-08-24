[Point](../../../Point.md) > [Status](../../Status.md) > [Mode_Status](../Mode_Status.md) > [Unoccupied_Mode_Status](#)
# Unoccupied_Mode_Status

**Display name:** Unoccupied Mode Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Mode_Status;1

---


## Child interfaces
* [Unoccupied_Cooling_Mode_Status](Unoccupied_Cooling_Mode_Status.md)
* [Unoccupied_Heating_Mode_Status](Unoccupied_Heating_Mode_Status.md)

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
