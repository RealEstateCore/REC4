[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Humidity_Setpoint](Humidity_Setpoint.md) > [Occupied_Humidity_Setpoint](.)
# Occupied_Humidity_Setpoint

**Display name:** Occupied Humidity Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Occupied_Humidity_Setpoint;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
