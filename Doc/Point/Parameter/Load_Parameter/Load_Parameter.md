[Point](../../Point.md) > [Parameter](../Parameter.md) > [Load_Parameter](#)
# Load_Parameter

**Display name:** Load Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Parameter;1

---


## Child interfaces
* [Max_Load_Setpoint](Max_Load_Setpoint.md)
* [Min_Load_Setpoint](Min_Load_Setpoint.md)

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
